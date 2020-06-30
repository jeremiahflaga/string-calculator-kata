using System;

namespace StringCalculatorKata
{
    internal class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var numbers = input.Split(",");
            var sum = 0;
            foreach (var number in numbers)
            {
                return int.Parse(number);
                //sum += int.Parse(number);
            }
            return sum;
        }
    }
}