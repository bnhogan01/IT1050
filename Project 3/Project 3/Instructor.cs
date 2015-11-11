
namespace Project_3
{
    class Instructor
    {
        //variable declaration

        public string Name;
        public string courseName;
        public string studentGrade;

        public Instructor(string firstName, string courseName)
        {
            this.Name = firstName;
            this.courseName = courseName;
        }

        public void setStudentGrade()
        {
            System.Console.Write("What is the Student's Name?");
            System.Console.ReadLine();

            System.Console.Write("What grade are you assigning?");
            System.Console.ReadLine();
        }

        public void SetStudentGrade(string studentName, int grade)
        {

        }
    }
}