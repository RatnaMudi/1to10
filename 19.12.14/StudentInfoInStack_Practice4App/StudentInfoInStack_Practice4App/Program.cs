using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoInStack_Practice4App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> studentStack= new Stack<Student>();

            Student student1 = new Student();
            student1.firstName = "ratna";
            student1.lastName = "mudi";

            Student student2 = new Student();
           student2.firstName = "masud";
            student2.lastName = "masud1";

            Student student3 = new Student();
            student3.firstName = "bristi";
            student3.lastName = "bristi1";

            studentStack.Push(student1);
            studentStack.Push(student2);
            studentStack.Push(student3);


            foreach (Student aStudent in studentStack)
            {
                Console.WriteLine("Full Name : " + aStudent.GetFullName());
            }

            Console.ReadLine();
        }
    }
}
