using System.Collections.Generic;
using System.Linq;

namespace TotalStudentCountApp
{
    internal class School 
    {
        
        private string NameOfSchool;
       
        public School(string nameOfSchool)
        {
            this.NameOfSchool = nameOfSchool;
        }

        public List<Class> aClass { get; internal set; } = new List<Class>();

        public int numberOfStudents
        {
            get
            {
                return this.aClass.Sum(x => x.NumberOfStudents);
            }

        }

        public override string ToString()
        {
            return this.NameOfSchool;
        }
    }
}