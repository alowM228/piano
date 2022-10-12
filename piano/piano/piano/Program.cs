using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine( " F1 - 1 октава");
            Console.WriteLine(" F2 - 2 октава");
            Console.WriteLine(" F3 - 3 октава");
            
            int[,] octav = new[,]
            {
{ 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 },
{ 523, 554, 587, 622, 659, 699, 740, 784, 830, 880, 932, 988 },
{ 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976},
};
            Console.WriteLine("Нажмите F4 чтобы поменять октаву");
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.F1)
            {
                zvuk(octav, 0);
            }
            if (Key.Key == ConsoleKey.F2)
            {
                zvuk(octav, 1);
            }
            if (Key.Key == ConsoleKey.F3)
            {
                zvuk(octav, 2);
            }
        }
        static void zvuk(int[,] octav, int n)
        {
            int f = 1;
            while (f == 1)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.A)
                {
                    Console.Beep(octav[n, 1], 450);
                }
                if (Key.Key == ConsoleKey.W)
                {
                    Console.Beep(octav[n, 2], 450);
                }
                if (Key.Key == ConsoleKey.S)
                {
                    Console.Beep(octav[n, 3], 450);
                }
                if (Key.Key == ConsoleKey.E)
                {
                    Console.Beep(octav[n, 4], 450);
                }
                if (Key.Key == ConsoleKey.D)
                {
                    Console.Beep(octav[n, 5], 450);
                }
                if (Key.Key == ConsoleKey.F)
                {
                    Console.Beep(octav[n, 6], 450);
                }
                if (Key.Key == ConsoleKey.T)
                {
                    Console.Beep(octav[n, 7], 450);
                }
                if (Key.Key == ConsoleKey.G)
                {
                    Console.Beep(octav[n, 8], 450);
                }
                if (Key.Key == ConsoleKey.Y)
                {
                    Console.Beep(octav[n, 9], 450);
                }
                if (Key.Key == ConsoleKey.H)
                {
                    Console.Beep(octav[n, 10], 450);
                }
                if (Key.Key == ConsoleKey.U)
                {
                    Console.Beep(octav[n, 11], 450);
                }
                if (Key.Key == ConsoleKey.J)
                {
                    Console.Beep(octav[n, 12], 450);
                }
                if (Key.Key == ConsoleKey.F4)
                {
                    Console.WriteLine();
                    Main();
                }
            }

        }
    }

}