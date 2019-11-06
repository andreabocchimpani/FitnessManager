using System;

namespace FitnessManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Mario", "Rossi", 20);
            c1.Age = -19;
            Customer c2 = new Customer("GG06112019", "Giorgio", "Gori", Gender.Male, DateTime.Now, 25, 1.82, 89);
            Console.WriteLine(c2.Description());
            Customer c3 = new Customer("FV06112019", "Federica", "Valente", Gender.Female, DateTime.Now, 25, 1.55, 63);
            Console.WriteLine(c3.Description());
        }
    }
}
