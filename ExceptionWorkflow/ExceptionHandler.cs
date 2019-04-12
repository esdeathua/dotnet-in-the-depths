using System;
using MW = ExceptionWorkflow.MessageWrapper;

namespace ExceptionWorkflow
{
    public class ExceptionHandler
    {
        private readonly ExceptionGenerator _exceptionGenerator;
        private delegate void CallHandlerDelegate();

        public ExceptionHandler()
        {
            _exceptionGenerator = new ExceptionGenerator();
        }

        public void ShowExceptionInfo()
        {
            CallHandler(() => _exceptionGenerator.GenerateException());
        }

        private void CallHandler(CallHandlerDelegate action)
        {
            Console.WriteLine("-----------------------------------------");
            try
            {
                // some code
                MW.TryHandlerMessage(action.Method.Name);
                action.Invoke();
            }
            catch (Exception exception)
            {
                // some code
                MW.CatchHandlerMessage(exception);
            }
            finally
            {
                // some code
                MW.FinallyHandlerMessage(". . . some code");
            }
        }

    }
}
