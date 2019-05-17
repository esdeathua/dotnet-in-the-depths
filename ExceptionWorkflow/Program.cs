using System;
using System.IO;

namespace ExceptionWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            MathTest();

            Console.ReadLine();
        }

        public static void FirstWork()
        {
            var exceptionHandler = new ExceptionHandler();
            int counter = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("Iteration: {0}\n", counter++);
                exceptionHandler.ShowExceptionInfo();

            } while (Console.ReadKey().KeyChar == (char)13);
        }

        /// <summary>
        /// Швидкість try-catch в циклах
        /// </summary>
        public static void SecondWord()
        {
            var random = new Random();
            int count = 1000;
            int errorCount = 0;

            Console.WriteLine();
            Console.WriteLine("+ + + + + + + + + + + + + +");
            for (int j = 0; j < 5; j++)
            {
                var beforeTime = DateTime.Now;
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        if (random.Next(0, 10) > 8)
                            throw new Exception();
                    }
                    catch
                    {
                        errorCount++;
                    }
                }
                var afterTime = DateTime.Now;
                Console.WriteLine("Count: {0}, Errors: {1}, Time: {2:G}",
                    count.ToString(),
                    errorCount.ToString(),
                    (afterTime - beforeTime));

                Console.WriteLine();
                errorCount = 0;
            }

            Console.WriteLine();
            Console.WriteLine("+ + + + + + + + + + + + + +");
            for (int j = 0; j < 5; j++)
            {
                var beforeTime2 = DateTime.Now;
                for (int i = 0; i < count * 10; i++)
                {
                    try
                    {
                        if (random.Next(0, 10) > 8)
                            throw new Exception();
                    }
                    catch
                    {
                        errorCount++;
                    }
                }
                var afterTime2 = DateTime.Now;
                Console.WriteLine("Count: {0}, Errors: {1}, Time: {2:G}",
                    (count * 10).ToString(),
                    errorCount.ToString(),
                    (afterTime2 - beforeTime2));

                Console.WriteLine();
                errorCount = 0;
            }

            Console.WriteLine();
            Console.WriteLine("+ + + + + + + + + + + + + +");
            for (int j = 0; j < 5; j++)
            {
                var beforeTime2 = DateTime.Now;
                for (int i = 0; i < count * 100; i++)
                {
                    try
                    {
                        // some operation
                        var rndInt = random.Next(0, 10);
                        rndInt ^= 3;
                        if (rndInt > 5)
                            rndInt = 0;
                        else
                            rndInt = 10;
                    }
                    catch
                    {
                        ;
                    }
                }
                var afterTime2 = DateTime.Now;
                Console.WriteLine("Count without errors: {0}, Time: {1:G}",
                    (count * 100).ToString(),
                    (afterTime2 - beforeTime2));

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("+ + + + + + + + + + + + + +");
            for (int j = 0; j < 5; j++)
            {
                var beforeTime = DateTime.Now;
                for (int i = 0; i < count * 100; i++)
                {
                    // some operation
                    var rndInt = random.Next(0, 10);
                    rndInt ^= 3;
                    if (rndInt > 5)
                        rndInt = 0;
                    else
                        rndInt = 10;
                }
                var afterTime = DateTime.Now;
                Console.WriteLine("Count without try-catch: {0}, Time: {1:G}",
                    (count * 100).ToString(),
                    (afterTime - beforeTime));

                Console.WriteLine();
            }

        }

        public static void MathTest()
        {
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("Math.Round(2.5): {0}", Math.Round(2.5));
            Console.WriteLine("Math.Round(2.5 + double.Epsilon): {0}", Math.Round(2.5m + (decimal)double.Epsilon, MidpointRounding.AwayFromZero));
        }
    }
}
