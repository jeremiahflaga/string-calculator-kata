using System;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string numbers) {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            char[] splitchar = {',', '\n'};
            string[] numArray = numbers.Split(splitchar);
            int sum = 0;
            foreach (string num in numArray)
                sum += int.Parse(num);

            return sum;
        }
    }
}
