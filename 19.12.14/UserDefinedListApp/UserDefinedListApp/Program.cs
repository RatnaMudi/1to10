using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> aStudents= new List<Student>();

            Student student1 = new Student();
            student1.regNo = "10";
            student1.firstName = "ratna";
            student1.lastName = "mudi";

            Student student2 = new Student();
            student2.regNo = "20";
            student2.firstName = "masud";
            student2.lastName = "masud1";

            Student student3 = new Student();
            student3.regNo = "30";
            student3.firstName = "bristi";
            student3.lastName = "bristi1";

            aStudents.Add(student1);
            aStudents.Add(student2);
            aStudents.Add(student3);


            foreach (Student aStudent in aStudents)
            {
                Console.WriteLine("Id : "+ aStudent.regNo+ ",  Name : "+aStudent.GetFullName());
            }

            Console.ReadLine();
        }
    }
}
