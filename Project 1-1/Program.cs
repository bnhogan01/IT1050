

namespace Project_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int userAge;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            
            // What is your firstName?

            System.Console.Write("What is your first name?");
            firstName=System.Console.ReadLine();
            
            //What is your middleInitial?

            System.Console.Write("What is your middleInitial?");
            middleInitial=System.Console.ReadLine();

            //What is your Last Name?


            System.Console.Write("What is your Last Name?");
            lastName=System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;

            System.Console.Write("Your fullName is :");
            System.Console.WriteLine(fullName);

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();

            //===========================================================================
            //===========================================================================

            //What is your height in Feet?

            System.Console.Write("What is your Height in Feet?");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(heightFeet);

            //What is your height in inches?

            System.Console.WriteLine("What is your height in Inches");
            heightInches = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine(heightInches);

            //Total Height in Centimeters

            totalHeightCM = (heightFeet * 12 + heightInches) * 2.5;
            System.Console.WriteLine("Your total height in CM's is :");
            System.Console.WriteLine(totalHeightCM);

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();

            //===========================================================================
            //===========================================================================

            System.Console.Write("How old are you? ");
            userAge = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? (true/false) ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            canVote = userAge >= 18 && isCitizen == true;

            System.Console.WriteLine("Your voter status is: " + canVote);

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}