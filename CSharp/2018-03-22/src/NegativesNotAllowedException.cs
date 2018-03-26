using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public class NegativesNotAllowedException : Exception
    {
        protected NegativesNotAllowedException(string message) : base(message) { }

        public static NegativesNotAllowedException Create(IEnumerable<int> negativeNumbers) {            
            string exceptionMessage = "negatives not allowed:";
            foreach (int num in negativeNumbers) {
                exceptionMessage += num.ToString() + ",";
            }
            
            return new NegativesNotAllowedException(exceptionMessage);
        }
    }
}
