using System;
using System.Collections.Generic;
using System.Threading;

namespace Berzerk
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(41, 16);

            GameMenus gameMenus = new GameMenus();
            gameMenus.runStart();
            
            Map map = new Map();
            Player player = new Player(5, 5);
            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(new Enemy(map));

            BuildGame buildGame = new BuildGame(player, map, enemies);
            GameRules gameRules = new GameRules(player, map, enemies, buildGame);

            Random random = new Random();

            Console.Clear();
            while (true)
            {
                if (Console.KeyAvailable)
                    gameRules.movePlayer(Console.ReadKey().KeyChar);

                if (random.Next(1, 101) < 5 && enemies.Count < 10)
                    enemies.Add(new Enemy(map));
                
                if (random.Next(1, 101) < 20)
                    gameRules.moveEnemy(random.Next(0, enemies.Count));
                
                buildGame.printArena();
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(100);

                if (gameRules.gameEnd == true)
                {
                    gameMenus.endMenu();
                    break;
                }
            } 
        }
    }
}
