using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDictionary
{
    public class Student
    {
        public int Id {get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Grade { get; set; }
        public Student(int id, string name, string email, string grade)
        {
            Id = id;
            Name = name;
            Email = email;
            Grade = grade;
        }

  public  static Dictionary<string,Student> GetStudentInfo()
        {
            var studentDictoinary = new Dictionary<string, Student>();
            var astudent = new Student(100, "Masum", "masum@gmail.com", "GV");
            studentDictoinary.Add("Mvc", astudent);
            astudent = new Student(101, "Basum", "Basum@gmail.com", "V");
            astudent = new Student(102, "Dasum", "Dasum@gmail.com", "V");
            studentDictoinary.Add("C#", astudent);
            studentDictoinary.Add("PHP", astudent);
            return studentDictoinary;
        }
    }
}
