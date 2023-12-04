using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;

namespace GameStore.Client;
// Store and manage information about games available on the system

    public static class GameClient
        {
            // Does not receive a new value
            private static List<Game> games = new()
            {
                new Game() 
                { 
                    Id= 1, 
                    Name="The Last of Us", 
                    Price=39.99m, 
                    Platforms="new",
                    Genre="Action",
                    ReleaseDate= new DateTime(2023, 2, 1)
                },
                new Game()
                {
                    Id= 2, 
                    Name="GTA", 
                    Price=69.99m, 
                    Platforms="new",
                    Genre="Action",
                    ReleaseDate= new DateTime(2023, 11, 1)
                }
            };
        // Returns an array of GameClient objects that contain information about the games stored in the games list.
        // Method that returns an array of Game objects.
       public static Game[] Getgames() 
        {
            return games.ToArray();
        }

        public static void AddGame (Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);
        }

       
    }
