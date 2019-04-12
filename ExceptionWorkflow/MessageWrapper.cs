using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionWorkflow
{
    public static class MessageWrapper
    {
        public static void CatchHandlerMessage(Exception exception)
        {
            Console.WriteLine("- - - Catch Handler - - -\n");

            if (exception.ToString() is string s && !string.IsNullOrEmpty(s))
            {
                string typeException = s.Substring(0, s.IndexOf(':'));
                Console.WriteLine("Exception type: {0}\n", typeException);
            }
            Console.WriteLine("Message: {0}\n", exception.Message);

            Console.WriteLine("Exception string: {0}\n", exception);

            foreach (var item in exception.Data.Values)
                Console.WriteLine("Exception Data info: {0}", item);
            Console.WriteLine("- - - - - - - - - - - - -\n");
        }

        public static void FinallyHandlerMessage(string Msg)
        {
            Console.WriteLine("- - - Finally Handler - - -");
            Console.WriteLine("MESSAGE: {0}", Msg);
            Console.WriteLine("- - - - - - - - - - - - -");
            Console.WriteLine();
        }

        public static void TryHandlerMessage(string Msg)
        {
            Console.WriteLine("- - - Try Handler - - -");
            Console.WriteLine("Method is run: {0}", Msg);
            Console.WriteLine("- - - - - - - - - - - - -");
            Console.WriteLine();
        }
    }
}
