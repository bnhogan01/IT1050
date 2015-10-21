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

            
            
            


            Person secondPerson = new Person();

            System.Console.WriteLine("What is Person Two's firstName?");
            System.Console.ReadLine(secondPerson.firstName);

            System.Console.WriteLine("What is Person Two's Last Name?");
            System.Console.ReadLine(secondPerson.lastName);

            System.Console.WriteLine("What is Person Two's Age?");
            System.Console.ReadLine(secondPerson.age);

            System.Console.WriteLine("Is Person Two Married?");  
            System.Console.ReadLine(secondPerson.isMarried);

            System.Console.WriteLine("If Person 2 is Married = (true), Then "What is His / Her Spouse's Name?");         
            System.Console.ReadLine(secondPerson.Spouse);
            
            Person thirdPerson = new Person

            System.Console.WriteLine("What is Person Three's firstName?");
            System.Console.ReadLine(thirdPerson.firstName);

            System.Console.WriteLine("What is Person Three's Last Name?");
            System.Console.ReadLine(thirdPerson.lastName);

            System.Console.WriteLine("What is Person Three's Age?");
            System.Console.ReadLine(thirdPerson.age);

            System.Console.WriteLine("Is Person Three Married?");
            System.Console.ReadLine(thirdPerson.isMarried?);

            System.Console.WriteLine("If Person Three is Married = (true), Then "What is His / Her Spouse's Name?");
            System.Console.ReadLine(thirdPerson.Spouse);



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
