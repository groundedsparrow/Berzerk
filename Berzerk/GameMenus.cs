using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berzerk
{
    internal class GameMenus
    {
        public void runStart()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                startMenu();
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        loop = false;
                        break;
                    case '2':
                        Console.Clear();
                        helpMenu();
                        Console.ReadLine();
                        break;
                }
            }
        }
        public void startMenu()
        {
            Console.WriteLine("#########################################");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#              +-----------+            #");
            Console.WriteLine("#              |  BERZERK  |            #");
            Console.WriteLine("#              +-----------+            #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#             [1] Start game            #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#             [2] Help                  #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#########################################");
        }

        public void helpMenu()
        {
            Console.WriteLine("#########################################");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#       [1] W,A,S,D - move keys         #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#       [2] F - shoot key               #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#       [3] Q - quit game               #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#        PRESS ENTER TO CONTINUE        #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#########################################");
        }

        public void endMenu()
        {
            Console.Clear();
            Console.WriteLine("#########################################");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#            +--------------+           #");
            Console.WriteLine("#            |  GAME OVER!  |           #");
            Console.WriteLine("#            +--------------+           #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#       THANK YOU FOR PLAYING :))       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#        PRESS ENTER TO CONTINUE        #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#########################################");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
