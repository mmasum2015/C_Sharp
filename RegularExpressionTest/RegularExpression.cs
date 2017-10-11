using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegularExpressionTest
{
    [TestClass]
    public class RegularExpression
    {
        [TestMethod]
        public void MatchTest()
        {
            string pattern = @"\""?([^\""]*)\""? (\d*) (\d*.\d*) (\d*-\d*)";
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            Match m = Regex.Match(input, pattern);
            Console.WriteLine("'{0}' found at index {1}", m.Value, m.Index);
        }
    }
}
