using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string input) {
            if (string.IsNullOrEmpty(input))
                return 0;
            
            int sum = 0;
            IList<int> negativeNumbers = new List<int>();
            foreach (string num in getNumbers(input)) {
                int n = int.Parse(num);
                sum += n;

                if (n < 0) {
                    negativeNumbers.Add(n);
                }
            }

            if (negativeNumbers.Count > 0)
                throw NegativesNotAllowedException.Create(negativeNumbers);

            return sum; 
        }

        private static string[] getNumbers(string input) {
            string strDelimeters = ",\n";
            string strNumbers;
            using (var reader = generateStreamReaderFromString(input)) {
                if (input.StartsWith("//")) {
                    strDelimeters = reader.ReadLine();
                    strDelimeters = strDelimeters.Substring(2, strDelimeters.Length - 2);
                }

                strNumbers = reader.ReadToEnd();
            }

            return strNumbers.Split(strDelimeters.ToCharArray());
        }

        private static StreamReader generateStreamReaderFromString(string s) {
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(s));
            var reader = new StreamReader(stream);
            stream.Position = 0;
            return reader;
        }
    }
}
