using System;
using Xunit;
using StringCalculator;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void should_return_zero_for_empty_string()
        {
            int sum = StringCalculator.Add("");
            Assert.Equal(0, sum);
        }

        [Fact]
        public void should_return_single_number_1()
        {
            int sum = StringCalculator.Add("1");
            Assert.Equal(1, sum);
        }

        [Fact]
        public void should_return_single_number_2()
        {
            int sum = StringCalculator.Add("2");
            Assert.Equal(2, sum);
        }
        
        [Fact]
        public void should_return_sum_of_two_numbers_separated_by_commas()
        {
            int sum = StringCalculator.Add("1,2");
            Assert.Equal(3, sum);
        }
        
        [Fact]
        public void should_return_sum_of_many_numbers_separated_by_commas()
        {
            int sum = StringCalculator.Add("1,2,3,4,5,6,7,8,9");
            Assert.Equal(45, sum);
        }
        
        [Fact]
        public void should_return_sum_of_two_numbers_separated_by_newlines()
        {
            int sum = StringCalculator.Add("1\n2");
            Assert.Equal(3, sum);
        }
        
        [Fact]
        public void should_return_sum_of_numbers_separated_by_commas_and_newlines()
        {
            int sum = StringCalculator.Add("1\n2,3");
            Assert.Equal(6, sum);
        }
    }
}
