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
                ExceptionMethod();
            }
            catch (Exception e)
            {
                // some code
                e.Data.Add("GenerateExceptionMethod", "call method what exception will generate");
                throw;
            }
        }

        private void ExceptionMethod()
        {
            int i = 3;
            for (int j = 0; j < 10; j++)
                i++;
            i -= 8;
            var rnd = new Random();
            var doubleValue = rnd.NextDouble();
            if (doubleValue <= 0.5d)
                throw new ArgumentException($"ArgumentException: i = {i}, value = {doubleValue}");
            i *= 8;
            throw new ArgumentOutOfRangeException($"ArgumentOutOfRangeException: result = {doubleValue * i}");
        }
    }
}
