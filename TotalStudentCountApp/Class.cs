namespace TotalStudentCountApp
{
    internal class Class 
    {
        public int NumberOfStudents;
        public string Course;

        public Class(string course ,int numberOfStudents)
        {
            this.Course = course;
            this.NumberOfStudents = numberOfStudents;
        }

        


        public override string ToString()
        {
            return this.NumberOfStudents.ToString();
        }
    }
}