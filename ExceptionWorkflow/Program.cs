using System;

namespace ExceptionWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var exceptionHandler = new ExceptionHandler();
            exceptionHandler.ShowExceptionInfo();
        }
    }
}
