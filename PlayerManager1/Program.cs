﻿using System;
using System.Collections.Generic;

namespace PlayerManager1 
{

    public class Program
    {

        private List<Player> playerList;


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

        private void Start()
        {
            string option;
            do
            {
                Console.WriteLine("Choose what u want to do:");
                Console.WriteLine("1- Insert Players & Scores");
                Console.WriteLine("2- Show Scores");
                Console.WriteLine("3- Players with higher scores than");
                Console.WriteLine("4- Leave the program");
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


        private void InsertPlayer()
        {
            Console.WriteLine("Insert name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Insert score: ");
            string score = Console.ReadLine();
            int numScore = int.Parse(score);
        }


        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            
            foreach (Player player in playersToList)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }


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