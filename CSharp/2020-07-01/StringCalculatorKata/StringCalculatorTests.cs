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

        [Fact]
        public void should_return_1_for_1()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1");

            Assert.Equal(1, sum);
        }

        [Fact]
        public void should_return_2_for_2()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("2");

            Assert.Equal(2, sum);
        }

        [Fact]
        public void should_return_1_for_1_with_comma()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1,");

            Assert.Equal(1, sum);
        }

        [Fact]
        public void should_return_2_for_2_with_comma()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("2,");

            Assert.Equal(2, sum);
        }

        [Fact]
        public void should_return_sum_of_two_numbers_separated_by_commas()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1,2");

            Assert.Equal(3, sum);
        }

        [Fact]
        public void should_return_sum_of_three_numbers_separated_by_commas()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1,2,3");

            Assert.Equal(6, sum);
        }

        [Fact]
        public void should_return_sum_of_two_numbers_separated_by_newline()
        {
            var strCalc = new StringCalculator();
            var sum = strCalc.Add("1\n2");

            Assert.Equal(3, sum);
        }
    }
}
