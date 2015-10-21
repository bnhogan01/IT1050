namespace Project_2
{
    class Person
    {

        //instance variable declaration

        public string firstName;
        public string lastName;
        public int age;
        public Person Spouse;

        static double averageAge;


        //Methods

        public bool isMarried()
        {
            return Spouse != null;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void PrintNameAndAge()
        {

        }

    }
}
