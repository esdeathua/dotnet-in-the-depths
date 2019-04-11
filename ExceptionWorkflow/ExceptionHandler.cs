using System;
using System.Collections.Generic;
using System.Text;
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
            CallHandler(() => _exceptionGenerator.GenerateExceptionOneDepth());
            CallHandler(() => _exceptionGenerator.GenerateExceptionTwoDepth());
            CallHandler(() => _exceptionGenerator.GenerateExceptionThreeDepth());
            CallHandler(() => _exceptionGenerator.GenerateExceptionFourDepth());
        }

        private void CallHandler(CallHandlerDelegate action)
        {
            Console.WriteLine("-----------------------------------------");
            try
            {
                MW.TryHandlerMessage(action.Method.Name);
                action.Invoke();
            }
            catch (Exception exception)
            {
                MW.CatchHandlerMessage(exception.Message);
            }
            finally
            {
                MW.FinallyHandlerMessage("//some finally code");
            }
        }

    }
}
