namespace ConsoleApp
{
    internal class student
    {
        private string v1;
        private string v2;

        public student(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public override string ToString()
        {
            return this.v1+this.v2;
        }
    }
}