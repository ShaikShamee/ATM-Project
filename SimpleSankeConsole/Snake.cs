using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleSankeConsole
{
    public class Snake
    {
        int Height = 30;
        int width = 20;
        int[] S = new int[50];
        int[] T = new int[50];

        int furitS;
        int furitT;
        int parts = 3;

        ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
        char key = 'W';

        Random random = new Random();


        public Snake()
        {
            S[0] = 5;
            T[0] = 5;
            Console.CursorVisible = false;
            furitS = random.Next(2, (width - 2));
            furitT = random.Next(2, (Height - 2));
        }
        public void WriteBoard()
        {
            Console.Clear();
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("-");
            }
            for (int i = 1; i <= (width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height + 2));
                Console.Write("-");
            }
            for (int i = 1; i <= (Height + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition((width + 2), i);
                Console.Write("|");
            }
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                consoleKeyInfo = Console.ReadKey();
                key = consoleKeyInfo.KeyChar;
            }
        }
        public void Logic()
        {
            if (S[0] == furitS)
            {
                if (T[0] == furitT)
                {
                    parts++;
                    furitS = random.Next(2, (width - 2));
                    furitT = random.Next(2, (Height - 2));

                }
            }

            for (int i = parts; i > 1; i--)
            {
                S[i - 1] = S[i - 2];
                T[i - 1] = T[i - 2];
            }
            switch (key)
            {
                case 'w':
                    T[0]--;
                    break;
                case 's':
                    T[0]++;
                    break;
                case 'd':
                    S[0]--;
                    break;
                case 'a':
                    S[0]++;
                    break;

            }
            for (int i = 0; i <= parts - 1; i++)
            {
                WritePoint(S[i], T[i]);
                WritePoint(furitS, furitT);

            }

            Thread.Sleep(100);
        }
        public void WritePoint(int s, int t)
        {
            Console.SetCursorPosition(s, t);
            Console.Write("#");
        }

        static void Main(string[] args)
        {
            Snake p = new Snake();
            while (true)
            {
                p.WriteBoard();
                p.Input();
                p.Logic();
            }
            Console.ReadLine();
        }
    }
    

}
        
    

