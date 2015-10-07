namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Person P2 = new Person();
            Person P3 = new Person();

            System.Console.WriteLine("Are you married? (y/n");
            
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                P1.Spouse = new Person();
            }
        }
    }
}