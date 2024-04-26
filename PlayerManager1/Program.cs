﻿using System;
using System.Collections.Generic;

namespace PlayerManager1 // >>> Change to PlayerManager2 for exercise 4 <<< //
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The list of all players.
        /// </summary>
        private List<Player> playerList;

        /// <summary>
        /// Program begins here.
        /// </summary>
        
        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        private static void Main()
        {

            Program prog = new Program();

            prog.Start();
        }


        private Program()
        {

            playerList = new List<Player>() {
                new Player("Kendrick", 972),
                new Player("Future", 230)
            };
        }
       /// <summary>
        /// Start the player listing program instance
        /// </summary>
        private void Start()
        {
            string option;
            do
            {
                ShowMenu();
                option = Console.ReadLine();

                
                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":                 
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }

                
                Console.Write("\nPress any key to continue...");
                Console.Read();
                Console.WriteLine("\n");

                
            } while (option != "4");
        }

        /// <summary>
        /// Shows the main menu.
        /// </summary>
        private void ShowMenu()
        {
                Console.WriteLine("Choose what u want to do:");
                Console.WriteLine("1- Insert Players & Scores");
                Console.WriteLine("2- Show Scores");
                Console.WriteLine("3- Players with higher scores than");
                Console.WriteLine("4- Leave the program");
        }
        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            Console.WriteLine("Insert name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insert score: ");
            string score = Console.ReadLine();
            int numScore = int.Parse(score);
        }

        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>

        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            
            foreach (Player player in playersToList)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }

        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            
            string score;

            Console.WriteLine("Insert minimum score: ");
            score =  Console.ReadLine();
            int minScore = int.Parse(score);

            foreach (Player player in GetPlayersWithScoreGreaterThan(minScore))
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }

        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            List<Player> players = new List<Player>();

            foreach (Player player in playerList)
            {
                if (player.Score > minScore)
                {
                    players.Add(player);
                }
            }

            return players;
        }
    }
}