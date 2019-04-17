using System;
using System.Runtime.CompilerServices;

namespace CommonConsoleApp
{
    class Program
    {
        private const string Command = "Write console command: ";
        private static event Action<ConsoleKey> EnterPress;
        private static bool _resetNeed = false;

        static void Main(string[] args)
        {
            Console.Title = "Hello World!";
            EnterPress += Program_EnterPress;
            ShowMenu();
        }

        private static void Program_EnterPress(ConsoleKey obj)
        {
            string command = Console.ReadLine()?.Replace(Command, string.Empty).ToLower();
            ExecuteCommand(command);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("\n> Console commands:\n" +
                              "\n help - show all command " +
                              "\n cls - clear console" +
                              "\n exit (q) - close console" +
                              "" +
                              "\n");
            Console.WriteLine(Command);

            do
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                    EnterPress?.Invoke(key.Key);

                if (key.Key == ConsoleKey.Backspace && Console.CursorLeft <= 1)
                {
                    Console.SetCursorPosition(1, Console.CursorTop);
                }
            } while (!_resetNeed);
            //do
            //{
            //    Console.Write(Command);
            //    string command = Console.ReadLine()?.Replace(Command, string.Empty).ToLower();
            //    ExecuteCommand(command);
            //} while (!_resetNeed);
        }

        private static void ExecuteCommand(string command)
        {
            switch (command)
            {
                case "help":
                    ShowMenu();
                    break;

                case "cls":
                    Console.Clear();
                    break;

                case "exit":
                case "q":
                    Console.WriteLine(" Closing...");
                    System.Threading.Thread.Sleep(500);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Command {0} not found!", command);
                    break;
            }
        }
    }
}
