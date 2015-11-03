using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Instructor John = new Instructor();

            John.Name = "John";
            John.courseName = "English";


            Instructor Mike = new Instructor();
            

            Mike.Name = "Mike";
            Mike.courseName = "Math";




            Student student1 = new Student();

            student1.Name = "Jane";
            student1.setGrade = 0;
            student1.Instructor = "John";

             Student student2 = new Student();

            student2.Name = "Joe";
            student2.setGrade = 0;
            student2.Instructor = "John";

            Student student3 = new Student();

            student3.Name = "Melissa";
            student3.setGrade = 0;
            student3.Instructor = "Mike";


            Student student4 = new Student();

            student4.Name = "Matt";
            student4.setGrade = 0;
            student4.Instructor = "Mike";


            System.Console.WriteLine("Hi. What is your Student's name?");
            System.Console.ReadLine();

            System.Console.WriteLine("What Grade Are You Assigning?")
                System.Console.Readline(setStudentGrade);





            






            ;
        }
    }
}
