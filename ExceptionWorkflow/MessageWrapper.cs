using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionWorkflow
{
    public static class MessageWrapper
    {
        public static void CatchHandlerMessage(string Msg)
        {
            Console.WriteLine("- - - Catch Handler - - -");
            Console.WriteLine("MESSAGE: {0}", Msg);
            Console.WriteLine("- - - - - - - - - - - - -");
            Console.WriteLine();
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
