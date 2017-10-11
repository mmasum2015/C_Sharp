﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIEAccountLib
{
    public class RegexMatchCounter
    {
       public int CountMatchingLines(string content, string regexPattern)
        {
            int rows = 0;
            StringReader sr = new StringReader(content);
            while (true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;
                var match = Regex.Match(line, regexPattern);
                if (match.Success)
                    rows++;
            }
            return rows;
        }
    }
}
