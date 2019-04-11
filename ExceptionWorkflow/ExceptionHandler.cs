using System;
using System.Collections.Generic;
using System.Text;
using MW = ExceptionWorkflow.MessageWrapper;

namespace ExceptionWorkflow
{
    public class ExceptionHandler
    {
        private ExceptionGenerator _exceptionGenerator;

        public ExceptionHandler()
        {
            _exceptionGenerator = new ExceptionGenerator();
        }

        public void ShowExceptionInfo()
        {
            FirstDepthCall();
            SecondDepthCall();
        }

        private void FirstDepthCall()
        {

        }

        private void SecondDepthCall()
        {
            try
            {
                
            }
            catch (Exception exception)
            {
                MW.CatchHandlerMessage(exception.Message);
            }
            finally
            {
                MW.FinallyHandlerMessage("//some code");
            }
        }

    }
}
