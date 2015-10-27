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

        public void StateYourNameAndAge()
        {
            System.Console.WriteLine(this.firstName + " " + " says, 'Hello'.");
            System.Console.WriteLine("My name is " + " " + this.GetFullName());
            System.Console.WriteLine("My age is " + this.age);

        }
         averageAge()=  
        {

            this.age += this.age += this.age / 3 ();


        }

    
 
}




}    
