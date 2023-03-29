using System;
using System.Collections.Generic;

namespace RaceTo21Interface
{
    public class Game
    {
        public static int numberOfPlayers;
        public static List<Player> players = new List<Player>();
        static CardTable cardTable;
        public static Deck deck = new Deck();
        public static int currentPlayer = 0;
        public static PlayTask nextTask;
        private static bool cheating = false;
        public static int pot = 0;
        public static int[] bets;
        public static int defaultValueOfBet = 1;
        public static int change = 0;
        public static Player roundWinner;
        public static Player finalWinner;


        public Game(CardTable c)
        {
            cardTable = c;
            deck.Shuffle();
            deck.ShowAllCards();
            nextTask = PlayTask.GetNumberOfPlayers;
        }

        /* Adds a player to the current game
         * Called by DoNextTask() method
         */
        public static void AddPlayer(string n)
        {
            players.Add(new Player(n));
        }

        /* Figures out what task to do next in game
         * as represented by field nextTask
         * Calls methods required to complete task
         * then sets nextTask.
         */
        public static void DoNextTask()
        {
            if (nextTask == PlayTask.GetNumberOfPlayers)
            {
                nextTask = PlayTask.GetNames;
            }
            else if (nextTask == PlayTask.GetNames)
            {
                nextTask = PlayTask.Bet;
            }
            else if(nextTask == PlayTask.Bet)
            {
                currentPlayer = 0;
                foreach (var player in players)
                {
                    player.setScore(0);
                    player.setStatus(PlayerStatus.active);
                    player.cards = new List<Card>();
                }
                nextTask = PlayTask.PlayerTurn;
            }
            else if (nextTask == PlayTask.PlayerTurn)
            {
                if (CheckRoundWinner() || !CheckActivePlayers())
                {
                    roundWinner = DoFinalScoring();
                    cardTable.AnnounceRoundWinner(roundWinner, pot);
                    nextTask = PlayTask.CheckForEnd;
                }
                else
                {
                    currentPlayer++;
                    if (currentPlayer > players.Count - 1)
                    {
                        currentPlayer = 0; // back to the first player...
                    }
                    while(players[currentPlayer].status == PlayerStatus.stay || players[currentPlayer].status == PlayerStatus.bust)
                    {
                        currentPlayer++;
                        if (currentPlayer > players.Count - 1)
                        {
                            currentPlayer = 0;
                        }
                    }
                    nextTask = PlayTask.PlayerTurn;
                }
            }
            else if (nextTask == PlayTask.CheckForEnd)
            {
                //Check if any player has won 80% of the total chips or if any player has no chips left(This is the new game end condition)
                if (!CheckGameOver())
                {
                    //If the game is not over, the remaining chips of all players will be displayed and a new round will be started
                    pot = 0;
                    change = -defaultValueOfBet;
                    for (int i = 0; i < bets.Length; i++)
                    {
                        bets[i] = defaultValueOfBet;
                        UpdateChip(i, change);
                    }
                    UpdatePot();
                    nextTask = PlayTask.Bet;
                }
                else
                {
                    nextTask = PlayTask.GameOver;
                }                
            }
            else if(nextTask == PlayTask.GameOver)
            {
                //If the game is over, find out who is the winner
                finalWinner = FindFinalWinnner();
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't know what to do now!");
                nextTask = PlayTask.GameOver;
            }
        }
        
        /* Calculate the total score of the player's hand
         * Is called by DoNextTask function playerTurn task
         * DoNextTask function provides the current player object
         * Return the number of score 
         */
        public static int ScoreHand(Player player)
        {
            int score = 0;
            if (cheating == true && player.status == PlayerStatus.active)
            {
                string response = null;
                while (int.TryParse(response, out score) == false)
                {
                    Console.Write("OK, what should player " + player.name + "'s score be?");
                    response = Console.ReadLine();
                }
                return score;
            }
            else
            {
                foreach (Card card in player.cards)
                {
                    string faceValue = card.id.Remove(card.id.Length - 1);
                    switch (faceValue)
                    {
                        case "K":
                        case "Q":
                        case "J":
                            score = score + 10;
                            break;
                        case "A":
                            score = score + 1;
                            break;
                        default:
                            score = score + int.Parse(faceValue);
                            break;
                    }
                }
            }
            return score;
        }
        
        /* Check if there is a player with the active status in all players
         * Is called by DoNextTask function CheckForEnd task
         * No parameter passed
         * Retuen a bool to let DoNextTask function know if have a player is active
         */
        public static bool CheckActivePlayers()
        {
            foreach (var player in players)
            {
                if (player.status == PlayerStatus.active)
                {
                    return true; // at least one player is still going!
                }
            }
            return false; // everyone has stayed or busted, or someone won!
        }


        /* This fuction will help the task of CheckForEnd to check corner case . When anyone get 21, win immediately. When all player bust but one , win immediately.
         * Is called by DoNextTask function CheckForEnd task
         * No parameter passed
         * Retuen a bool to let DoNextTask function know if have a player is active
        */
        public static bool CheckRoundWinner()
        {
            int bustcounter = 0;
            foreach (var player in players)
            {
                if (player.status == PlayerStatus.win)
                {
                    return true;
                }
            }

            foreach(var player in players)
            {
                if (player.status == PlayerStatus.bust)
                {
                    bustcounter++;
                    if(bustcounter == players.Count - 1)//If the bust player count has reached one less player total,the last one win immediately
                    {
                        return true;
                    }
                }
            }
            return false; 
        }
        
       /* Check if the game is over
        * Is called by DoNextTask function CheckForEnd task
        * No parameter passed
        * Retuen a bool to let DoNextTask function know whether the conditions for the end of the game are met
        */
        public static bool CheckGameOver()
        {
            foreach(var player in players)
            {
                if(player.chip >= ((100 * numberOfPlayers) * 0.8) || player.chip == 0)
                {
                    return true;
                }
            }
            return false;
        }

       /* Find out who is the final winner
        * Is called by DoNextTask function CheckForEnd task
        * No parameter passed
        * Retuen Player object who is the final winner
        */
        public static Player FindFinalWinnner()
        {
            int highestChip = 0;
            foreach (var player in players)
            {
                if(player.chip > highestChip)
                {
                    highestChip = player.chip;
                }
            }
            Player p =  players.Find(player => player.chip == highestChip);
            p.setStatus(PlayerStatus.winner);
            return p;
        }

        /* Find out who is the winner of the current round based on the player state or score
         * Is called by DoNextTask function CheckForEnd task
         * No parameter passed
         * Retuen Player object who is the round winner
         */
        public static Player DoFinalScoring()
        {
            int highScore = 0;
            foreach (var player in players)
            {
                cardTable.ShowHand(player);
                if (player.status == PlayerStatus.win) // someone hit 21
                {
                    roundWinner = player;
                    return roundWinner;
                }
                if (player.status == PlayerStatus.stay || player.status == PlayerStatus.active) // if all bust but one, the remaining player also can win
                {
                    if (player.score > highScore)
                    {
                        highScore = player.score;
                    }
                }
                // if busted don't bother checking!
            }
            if (highScore > 0) // someone scored, anyway!
            {
                // find the FIRST player in list who meets win condition
                roundWinner = players.Find(player => player.score == highScore);
                roundWinner.setStatus(PlayerStatus.win);
                return roundWinner;
            }
            return null; // everyone must have busted because nobody won!
        }
        
        /* Updates the player's remaining chips based on the player's input
         * Is called by GameTable page
         * Pass two parameter that one is the index of the player another one is the change of the bet compare with the previous bet
         * No return
         */
        public static void UpdateChip(int playerIndex,int change)
        {
            players[playerIndex].setChip(players[playerIndex].chip + change);
        }
        
        /* Update the current pot based on how much the player has bet
         * Is called by GameTable page
         * No parameter passed 
         * No return
         */
        public static void UpdatePot()
        {
            pot = 0;
            for (int i = 0; i < bets.Length; i++)
            {
                pot += bets[i];
            }
        }
        
        /* Draw a card from the top of the deck
         * Is called by GameTable page
         * Pass the current player as the parameter
         * No return
         */
        public static void DrawCard(Player player)
        {
            Card card = deck.DealTopCard();
            player.cards.Add(card);
            player.setScore(ScoreHand(player));
            if (player.score > 21)
            {
                player.setStatus(PlayerStatus.bust);
            }
            else if (player.score == 21)
            {
                player.setStatus(PlayerStatus.win);
            }
        }

        /* Set the player's status to stay
         * Is called by GameTable page
         * Pass the current player as the parameter
         * No return
         */
        public static void Stay(Player player)
        {
            player.setStatus(PlayerStatus.stay);
        }
    }
}
