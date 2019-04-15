using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionWorkflow
{
    public class ExceptionGenerator
    {
        private readonly Random _random = new Random();

        public void GenerateException()
        {
            try
            {
                // some code
                GenerateExceptionOneDepth();
            }
            catch (Exception e)
            {
                // some code
                e.Data.Add("GenerateException", "GenerateException method call");

                if (_random.NextDouble() > 0.5d)
                    throw;
                else
                {
                    e.Data.Add("ThrowE", "is throw e");
                    throw e;
                }
            }
        }

        private void GenerateExceptionOneDepth()
        {
            try
            {
                // some code
                GenerateExceptionMethod();
            }
            catch (Exception e)
            {
                // some code
                e.Data.Add("GenerateExceptionOneDepth", "GenerateExceptionOneDepth method call");
                throw;
            }
        }

        private void GenerateExceptionMethod()
        {
            try
            {
                // some code
                throw new NullReferenceException("Oh! reference is null!");
            }
            catch (Exception e)
            {
                // some code
                e.Data.Add("GenerateExceptionMethod", "call method what exception will generate");
                throw;
            }
        }
    }
}
