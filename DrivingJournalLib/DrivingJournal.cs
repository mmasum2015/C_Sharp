﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingJournalLib
{
    public class DrivingJournal
    {
        private List<Entry> entries = new List<Entry>();
        public decimal MilesDriven(int year, int month)
        {
            return entries
                 .Where(entry => entry.Year == year && entry.Month == month)
                 .Sum(entry => entry.Miles);
                
        }

        public void AddEntry(int year, int month, decimal miles, string description)
        {
            entries.Add(new Entry { Year = year, Month = month, Miles = miles, Description = description });
        }
    }
}
