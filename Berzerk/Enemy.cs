using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerk
{
    internal class Enemy
    {
        public int x;
        public int y;

        public Enemy(Map map)
        {
            Random random = new Random();
            int xRand;
            int yRand;

            do
            {
                xRand = random.Next(1, map.getHeight() - 2);
                yRand = random.Next(1, map.getWidth() - 2);
            } while (map.isWall(xRand, yRand) == true || map.isEnd(xRand, yRand) == true);

            this.x = xRand;
            this.y = yRand;
        }
    }
}
