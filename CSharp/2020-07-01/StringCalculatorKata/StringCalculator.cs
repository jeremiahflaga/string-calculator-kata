﻿using System;

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

            return int.Parse(input);
        }
    }
}