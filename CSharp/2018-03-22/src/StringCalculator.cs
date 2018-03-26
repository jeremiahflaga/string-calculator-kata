using System;
using System.IO;
using System.Text;

namespace StringCalculator
{
    public class StringCalculator
    {
        public static int Add(string input) {
            if (string.IsNullOrEmpty(input))
                return 0;
            
            int sum = 0;
            bool hasNegatives = false;
            string exceptionMessage = "negatives not allowed:";
            foreach (string num in getNumbers(input)) {
                int n = int.Parse(num);
                sum += n;

                if (n < 0) {
                    hasNegatives = true;
                    exceptionMessage += n.ToString() + ",";
                }
            }

            if (hasNegatives)
                throw new Exception(exceptionMessage);

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
