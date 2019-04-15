using System;

namespace ExceptionWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var exceptionHandler = new ExceptionHandler();
            int counter = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Iteration: {0}\n", counter++);
                exceptionHandler.ShowExceptionInfo();

            } while (Console.ReadKey().KeyChar == (char) 13);
        }
    }
}
