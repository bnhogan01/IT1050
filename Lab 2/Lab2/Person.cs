namespace Lab2
{
    class Person
    {
        // Variables

        public string firstName;
        public string lastName;
        public int Age;
        public Person Spouse;

        static int averageAge;

        // Methods

        public bool isMarried()
        {
            return Spouse != null;
        }
    }
}