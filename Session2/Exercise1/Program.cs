using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var dnpStudent = new DNPStudent();

            student.SayHi();
            dnpStudent.SayHi();

            // upcasting child object
            // virtual override => child method used
            // hiding with new => parent method used
            student = dnpStudent;
            student.SayHi();
        }
    }
}
