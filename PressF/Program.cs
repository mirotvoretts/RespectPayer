using System;
using System.IO;

namespace PressF
{
    public class RespectPayer
    {
        private readonly ConsoleColor _defaultTextColor = Console.ForegroundColor;

        public void Start()
        {
            SetInitialConsoleDimensions();
            Ui.PrintLogo();
            
            Console.Write("\nWho do you want to pay respect to?: ");
            MakeInputRed(out string? name);

            Console.CursorVisible = false;
            
            ConsoleKeyInfo pressedKey;
            do
            {
                Console.Write("\rYou pressed the button: ");
                MakeInputRed(out pressedKey);
            } while (pressedKey.Key != ConsoleKey.F);

            Console.WriteLine($"\n\nYou paid respect to {name}!");
        }
        
        private void MakeInputRed(out string? input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            input = Console.ReadLine();
            Console.ForegroundColor = _defaultTextColor;
        }

        private void MakeInputRed(out ConsoleKeyInfo input)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            input = Console.ReadKey();
            Console.ForegroundColor = _defaultTextColor;
        }

        private void SetInitialConsoleDimensions()
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 15;
        }
    }
    
    public static class Ui
    {
        public static void PrintLogo()
        {
            Console.WriteLine(@" _____ _____ _____ _____ _____    _____    _____ _____    _____ _____ __ __ ");
            Console.WriteLine(@"|  _  | __  |   __|   __|   __|  ||F  ||  |_   _|     |  |  _  |  _  |  |  |");
            Console.WriteLine(@"|   __|    -|   __|__   |__   |  ||___||    | | |  |  |  |   __|     |_   _|");
            Console.WriteLine(@"|__|  |__|__|_____|_____|_____|  |/___\|    |_| |_____|  |__|  |__|__| |_|  ");
            Console.WriteLine();
            Console.WriteLine(@"             _____ _____ _____ _____ _____ _____ _____ ");
            Console.WriteLine(@"            | __  |   __|   __|  _  |   __|     |_   _|");
            Console.WriteLine(@"            |    -|   __|__   |   __|   __|   --| | |  ");
            Console.WriteLine(@"            |__|__|_____|_____|__|  |_____|_____| |_|  ");
        }
    }

    abstract class Program
    {
        private static void Main() { }
    }
}
