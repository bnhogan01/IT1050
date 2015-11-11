using System;
namespace Project_3
{
    static class Program
    { 
        [STAThread]
        static void Main()
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student student1 = new Student();
            student1.Name = "Jane";
            student1.setGrade(0);
            student1.Teacher = John;

            Student student2 = new Student();

            student2.Name = "Joe";
            student2.setGrade(0);
            student2.Teacher = John; 

            Student student3 = new Student();

            student3.Name = "Melissa";
            student3.setGrade(0);
            student3.Teacher = Mike;


            Student student4 = new Student();

            student4.Name = "Matt";
            student4.setGrade(0);
            student4.Instructor = "Mike";


            //System.Console.WriteLine("Hi. What is your Student's name?");
            //System.Console.ReadLine();

            //System.Console.WriteLine("What Grade Are You Assigning?")
            //    System.Console.setStudentGrade);





            






            //;
        }
    }
}