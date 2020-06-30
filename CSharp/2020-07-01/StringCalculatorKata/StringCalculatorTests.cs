using System;
using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculatorTests
    {
        [Fact]
        public void should_return_zero_for_empty_string()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("");

            Assert.Equal(0, sum);
        }
    }
}
