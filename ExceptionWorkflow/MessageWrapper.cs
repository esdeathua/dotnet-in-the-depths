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
            Console.WriteLine(Msg);
            Console.WriteLine("- - - - - - - - - - - - -");
        }

        public static void FinallyHandlerMessage(string Msg)
        {
            Console.WriteLine("- - - Finally Handler - - -");
            Console.WriteLine(Msg);
            Console.WriteLine("- - - - - - - - - - - - -");
        }
    }
}
