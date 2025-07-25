using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Game
{
    class Program
    {
            // Bit map representation of the table
            char[,] grid =
            {
                    { '1', '2', '3' },
                    { '4', '5', '6' },
                    { '7', '8', '9' }
            }; 
            int input1, input2;  // User input data holders
            bool result = false; // Helper VAR 
            char playerSign1 = 'X', playerSign2 = 'O';  // Symbol VARs
            string name1, name2;  // Player name VAR

            // Method to visuale the bit map VAR
            public void visualize()
            {
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    Console.WriteLine($"  {grid[0, 0]}  |  {grid[0, 1]}  |  {grid[0, 2]}  ");
                    Console.WriteLine(" ---------------");
                    Console.WriteLine($"  {grid[1, 0]}  |  {grid[1, 1]}  |  {grid[1, 2]}  ");
                    Console.WriteLine(" ---------------");
                    Console.WriteLine($"  {grid[2, 0]}  |  {grid[2, 1]}  |  {grid[2, 2]}  ");
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
            }

            // Player one input method
            public void gameplay1()
            {
                    Console.WriteLine("Player 1 select your option : ");
                    input1 = Convert.ToChar(Console.ReadLine());

                    if (input1 == grid[0, 0]) { grid[0, 0] = playerSign1; }
                    if (input1 == grid[0, 1]) { grid[0, 1] = playerSign1; ; }
                    if (input1 == grid[0, 2]) { grid[0, 2] = playerSign1; }
                    if (input1 == grid[1, 0]) { grid[1, 0] = playerSign1; }
                    if (input1 == grid[1, 1]) { grid[1, 1] = playerSign1; }
                    if (input1 == grid[1, 2]) { grid[1, 2] = playerSign1; }
                    if (input1 == grid[2, 0]) { grid[2, 0] = playerSign1; }
                    if (input1 == grid[2, 1]) { grid[2, 1] = playerSign1; }
                    if (input1 == grid[2, 2]) { grid[2, 2] = playerSign1; }
            }

        // Player one input method
            public void gameplay2()
            {
                    Console.WriteLine(" Player2  select your option : ");
                    input2 = Convert.ToChar(Console.ReadLine());

                    if (input2 == grid[0, 0]) { grid[0, 0] = playerSign2; }
                    if (input2 == grid[0, 1]) { grid[0, 1] = playerSign2; }
                    if (input2 == grid[0, 2]) { grid[0, 2] = playerSign2; }
                    if (input2 == grid[1, 0]) { grid[1, 0] = playerSign2; }
                    if (input2 == grid[1, 1]) { grid[1, 1] = playerSign2; }
                    if (input2 == grid[1, 2]) { grid[1, 2] = playerSign2; }
                    if (input2 == grid[2, 0]) { grid[2, 0] = playerSign2; }
                    if (input2 == grid[2, 1]) { grid[2, 1] = playerSign2; }
                    if (input2 == grid[2, 2]) { grid[2, 2] = playerSign2; }
            }


            static void Main(string[] args)
            {
                    int num = 0;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Program game = new Program();

                    Console.WriteLine(" Player one = X  Player 2 = O ");
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    Console.WriteLine($"  1  |  2  |  3  ");
                    Console.WriteLine(" ---------------");
                    Console.WriteLine($"  4  |  5  |  6  ");
                    Console.WriteLine(" ---------------");
                    Console.WriteLine($"  7  |  8  |  9  ");
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    Console.WriteLine(" "); //new line
                    
                    do
                    {

                            game.gameplay1();
                            game.visualize();
                            game.gameplay2();
                            num++;

                    } while (num < 9);
  
            }

    }
}


