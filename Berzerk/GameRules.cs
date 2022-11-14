using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerk
{
    internal class GameRules
    {
        private Player player;
        private Map map;
        private List<Enemy> enemies;
        private BuildGame buildGame;
        public bool gameEnd = false;
        private char lastDirection;

        public GameRules(Player player, Map map, List<Enemy> enemies, BuildGame buildGame)
        {
            this.player = player;
            this.map = map;
            this.enemies = enemies;
            this.buildGame = buildGame;
        }

        public void movePlayer(char command)
        {
            switch (command)
            {
                case 'q':
                    gameEnd = true;
                    break;
                case 'w':
                    lastDirection = 'w';
                    if (map.isEnd(player.x - 1, player.y) == true)
                        gameEnd = true;

                    if (buildGame.isEnemy(player.x - 1, player.y))
                        gameEnd = true;

                    if (map.isWall(player.x - 1, player.y) == false)
                        player.x--;
                    break;
                case 's':
                    lastDirection = 's';
                    if (map.isEnd(player.x + 1, player.y) == true)
                        gameEnd = true;

                    if (buildGame.isEnemy(player.x + 1, player.y))
                        gameEnd = true;

                    if (map.isWall(player.x + 1, player.y) == false)
                        player.x++;
                    break;
                case 'a':
                    lastDirection = 'a';
                    if (map.isEnd(player.x, player.y - 1) == true)
                        gameEnd = true;

                    if (buildGame.isEnemy(player.x, player.y - 1))
                        gameEnd = true;

                    if (map.isWall(player.x, player.y - 1) == false)
                        player.y--;
                    break;
                case 'd':
                    lastDirection = 'd';
                    if (map.isEnd(player.x, player.y + 1) == true)
                        gameEnd = true;

                    if (buildGame.isEnemy(player.x, player.y + 1))
                        gameEnd = true;

                    if (map.isWall(player.x, player.y + 1) == false)
                        player.y++;
                    break;
                case 'f':
                    shoot(lastDirection);
                    break;
            }
        }

        public void moveEnemy(int index)
        {
            Random random = new Random();
            switch (random.Next(1, 5))
            {
                case 1:
                    if (map.isWall(enemies[index].x - 1, enemies[index].y) == false && map.isEnd(enemies[index].x - 1, enemies[index].y) == false)
                        enemies[index].x--;
                    break;
                case 2:
                    if (map.isWall(enemies[index].x + 1, enemies[index].y) == false && map.isEnd(enemies[index].x + 1, enemies[index].y) == false)
                        enemies[index].x++;
                    break;
                case 3:
                    if (map.isWall(enemies[index].x, enemies[index].y - 1) == false && map.isEnd(enemies[index].x, enemies[index].y - 1) == false)
                        enemies[index].y--;
                    break;
                case 4:
                    if (map.isWall(enemies[index].x, enemies[index].y + 1) == false && map.isEnd(enemies[index].x, enemies[index].y + 1) == false)
                        enemies[index].y++;
                    break;
            }
        }

        private void shoot(char direction)
        {
            int index = 1;
            switch (direction)
            {
                case 'w':
                    while (map.isWall(player.x - index, player.y) == false && map.isEnd(player.x - index, player.y) == false)
                    {
                        if (buildGame.isEnemy(player.x - index, player.y) == true)
                        {
                            enemies.RemoveAt(buildGame.returnEnemyIndex(player.x - index, player.y));
                        }
                        index++;
                    }
                    break;
                case 's':
                    while (map.isWall(player.x + index, player.y) == false && map.isEnd(player.x + index, player.y) == false)
                    {
                        if (buildGame.isEnemy(player.x + index, player.y) == true)
                        {
                            enemies.RemoveAt(buildGame.returnEnemyIndex(player.x + index, player.y));
                        }
                        index++;
                    }
                    break;
                case 'a':
                    while (map.isWall(player.x, player.y - index) == false && map.isEnd(player.x, player.y - index) == false)
                    {
                        if (buildGame.isEnemy(player.x, player.y - index) == true)
                        {
                            enemies.RemoveAt(buildGame.returnEnemyIndex(player.x, player.y - index));
                        }
                        index++;
                    }
                    break;
                case 'd':
                    while (map.isWall(player.x, player.y + index) == false && map.isEnd(player.x, player.y + index) == false)
                    {
                        if (buildGame.isEnemy(player.x, player.y + index) == true)
                        {
                            enemies.RemoveAt(buildGame.returnEnemyIndex(player.x, player.y + index));
                        }
                        index++;
                    }
                    break;
            }
        }
    }
}
