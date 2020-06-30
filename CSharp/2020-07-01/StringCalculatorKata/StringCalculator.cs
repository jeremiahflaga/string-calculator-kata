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

            var numbers = input.Split(",\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += int.Parse(number);
            }
            return sum;
        }
    }
}