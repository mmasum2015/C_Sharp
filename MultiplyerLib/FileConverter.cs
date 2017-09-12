using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyerLib
{
  public  class FileConverter
    {
        public string Transfer(string row)
        {
            string[] tokens = row.Split(';');
            var firstName = tokens[0].ToUpper();
            var lasttName = tokens[1].ToUpper();
            var years = DateTime.Now.Year - int.Parse(tokens[2]);
            var message = $"{firstName} {lasttName} {years} YEARS OLD";
            return message;
        }
      
        public void TransformFile(string inputName, string outputName)
        {
            StringWriter sw = new StringWriter();
            string[] lines = File.ReadAllLines(inputName);
            foreach (var line in lines)
            {
                sw.WriteLine(Transfer(line));
            }
            sw.Close();
            File.WriteAllText(outputName, sw.ToString());
        }
    }
}
