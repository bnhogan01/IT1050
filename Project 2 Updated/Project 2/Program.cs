namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person ();

            //User input for firstPerson

            System.Console.WriteLine("What is the firstPerson's firstName?");
            firstPerson.firstName = System.Console.ReadLine();

            System.Console.WriteLine("What is the firstPerson's lastName?");
            firstPerson.lastName = System.Console.ReadLine();

            System.Console.WriteLine("What is the firstPerson's Age?");
            firstPerson.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is Person 1 Married? (y/n) ");
            bool isMarried = System.Console.ReadLine().StartsWith("y");

            if (isMarried)
            {
                firstPerson.Spouse = new Person();
                System.Console.WriteLine("What is His / Her Spouses Name?");
                firstPerson.Spouse.firstName = System.Console.ReadLine();
            }

        //User Input for Second Person
        
            Person secondPerson = new Person();

            System.Console.WriteLine("What is Person Two's firstName?");
            System.Console.ReadLine();

            System.Console.WriteLine("What is Person Two's Last Name?");
            System.Console.ReadLine();

            System.Console.WriteLine("What is Person Two's Age?");
            secondPerson.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is Person Two Married? (y/n) ");
            bool isMarried = System.Console.ReadLine().StartsWith("y");

            if (isMarried)
            {
                secondPerson.Spouse = new Person();
                System.Console.WriteLine("What is His / Her Spouses Name?");
                secondPerson.Spouse.firstName = System.Console.ReadLine();
            }

            // User Inputs for Third person

            Person thirdPerson = new Person();

            System.Console.WriteLine("What is Person Three's firstName?");
            System.Console.ReadLine();

            System.Console.WriteLine("What is Person Three's Last Name?");
            System.Console.ReadLine();

            System.Console.WriteLine("What is Person Three's Age?");
            thirdPerson.age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is Person Three Married? (y/n) ");
            bool isMarried = System.Console.ReadLine().StartsWith("y");

            if (isMarried)
            {
                thirdPerson.Spouse = new Person();
                System.Console.WriteLine("What is His / Her Spouses Name?");
                thirdPerson.Spouse.firstName = System.Console.ReadLine();
            }



            System.Console.WriteLine(firstPerson.GetFullName);
            System.Console.WriteLine(firstPerson.age);
            System.Console.WriteLine(firstPerson.Spouse);
          
            System.Console.WriteLine(secondPerson.GetFullName);
            System.Console.WriteLine(secondPerson.age);
            System.Console.WriteLine(secondPerson.Spouse);


            System.Console.WriteLine(thirdPerson.GetFullName);
            System.Console.WriteLine(thirdPerson.age);
            System.Console.WriteLine(thirdPerson.Spouse);
            
            Public void ("firstPerson.PrintNameandAge");


            Public void ("secondPerson.PrintNameandAge");
            Public void ("thirdPerson.PrintNameandAge");      
            
            
            )
                




        }
    }
}
