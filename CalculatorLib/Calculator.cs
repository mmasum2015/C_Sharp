﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        private string buffer = "";
        private List<int> numbers = new List<int>();
        public int Display { get; set; }

        public void PowerOn()
        {
            Display = 0;
        }

        public void Press(string key)
        {
            //Display = int.Parse(key);
            if (key == "+")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
            }
            else if (key == "=")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
                Display = numbers.Sum();
            }
            else
            {
                //Two numbers side by side
                buffer += key;
                Display = int.Parse(buffer);
            }
           
        }
    }
}
