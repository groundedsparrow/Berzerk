using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerk
{
    internal class BuildGame
    {
        private Player player;
        private List<Enemy> enemies;
        private Map map;

        public BuildGame(Player player, Map map, List<Enemy> enemies)
        {
            this.player = player;
            this.map = map;
            this.enemies = enemies;
        }

        public void printArena()
        {
            for (int i = 0; i < map.getHeight(); i++)
            {
                for (int j = 0; j < map.getWidth(); j++)
                {
                    if (player.x == i && player.y == j)
                        Console.Write('@');
                    else if (isEnemy(i, j))
                        Console.Write('O');
                    else if (map.isWall(i, j))
                        Console.Write('#');
                    else if (map.isEnd(i, j))
                        Console.Write('|');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public bool isEnemy(int x, int y)
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].x == x && enemies[i].y == y)
                    return true;
            }

            return false;
        }
    }
}