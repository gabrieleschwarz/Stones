using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miau
{
    class Program
    {
        static void Main(string[] args)
        {
            // erstmal player fertig machen. bewegung und switchen zwischen g u r 

            //window Size
            int width = 40;
            int height = 20;
            Console.Title = "Stones";

            Console.SetWindowSize(width + 2, height + 2);
            Console.SetBufferSize(width + 2, height + 2);
            //Playground size


            Console.BackgroundColor = ConsoleColor.Gray;

            for (int x = 0; x < width + 2; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ");

                }
            }

            //Playground details

            Console.SetCursorPosition(20, 0);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Punkte");
            Console.SetCursorPosition(20, 1);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("   ");
            Console.SetCursorPosition(10, 0);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("Wähle");
            Console.SetCursorPosition(10, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("G");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(11, 1);
            Console.Write("R");
            Console.SetCursorPosition(10, 2);
            //User input
            String player = Console.ReadLine().ToLower();
            // Punkte /Points
            int points = 0;
            Console.SetCursorPosition(20, 1);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(points);
            //Stones data

            Coordinate stone1;
            stone1.X = 4;
            stone1.Y = 5;
            Stone1();
            Stone2();
            Random rnd = new Random();
            int positionX = rnd.Next(1, 41);
            int positionY = rnd.Next(5, 21);



            //Player G/R
            
            PlayerG();



            //Game construct


            do
            {

                if (player == "g")
                {
                    PlayerG();
                }
                else if (player == "r")
                {
                    PlayerR();
                }
                else
                {
                    Console.SetCursorPosition(21, 10);
                    Console.WriteLine("FALSCHE EINGABE");
                }
            }
            while (points < 10);
        
            //End
            if (points > 10)
            { bool running = false; }
            Console.ReadKey();
            
        }

        //Player G
        static void PlayerG()
        {

            Random rnnd = new Random();
            Coordinate gposition;
            gposition.X = rnnd.Next(5, 19);
            gposition.Y = rnnd.Next(1, 39);
            Console.SetCursorPosition(gposition.Y, gposition.X);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("G");

        }


        //Player R
        static void PlayerR()
        {
            Console.SetCursorPosition(30, 11);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("R");

        }

        static void Stone1()
        {
            Console.SetCursorPosition(4, 5);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o");
        }

        static void Stone2()
        {
            Console.SetCursorPosition(27, 9);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("o");
        }

        struct Coordinate
        {
            public int X;
            public int Y;
        }

        enum Direction
        { Right,
        Down,
        Left,
        Up
        }
    }
}
