using System;

namespace CsharpSample
{
    class Program
    {
        static void Main(string[] args)
        {

           startpoint:Console.WriteLine("===========================\n Welcome to our Project \n ==============================================");
            Console.WriteLine("1-help\n2-start\n3-setting\n4-Exit\n ------------------");
            string start;

            start = Console.ReadLine();

            if(start== "1")
            {
                Console.Clear();
                Console.WriteLine("===================================\nany text here\n=====================================\n*-Back");
                string gostart = Console.ReadLine();
                if(gostart=="*")
                {
                    Console.Clear();
                    goto startpoint;
                }
            }
            else if(start == "2")
            {
                Console.Clear();
                Console.WriteLine("=================================\n1-Calculator\n2-\n==========================================\n*-Back");
                string gostart = Console.ReadLine();
                if (gostart == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }
            }
              else if(start == "3")
            {
                Console.Clear();
                colorsetting: Console.WriteLine("Setting\\interface\n1-white\n2-blue\n3-red\n*-Back");
                string interfacechoose;
                interfacechoose = Console.ReadLine();
                if (interfacechoose == "1")
                {
                    Console.Clear();
                   n:Console.WriteLine("Setting\\interface\n1-white\n2-blue\n3-red\n4-black\n*-Back");
                    string color;
                    color = Console.ReadLine();
                    if (color == "1")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        goto n;
                    }
                    else if (color == "2")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        goto n;

                    }
                    else if (color == "3")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        goto n;

                    }
                    else if (color == "*")
                    {
                        Console.Clear();
                        goto colorsetting;
                    }

                }
                else if(interfacechoose == "*")
                {
                    Console.Clear();
                    goto startpoint;
                }
                else if(start == "4")
                {
                    Environment.Exit(0);
                }

            }

        }
    }
}
