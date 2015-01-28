using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students= new Student[3];

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

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

           

            foreach (Student aStudent in students)
            {
                Console.WriteLine(aStudent.regNo +"  "+ aStudent.GetFullName());
                
            }
            Console.ReadLine();
        }
    }
}
