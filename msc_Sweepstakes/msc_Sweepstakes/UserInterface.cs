using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class UserInterface
    {
        Contestant sweepstakesContestant;
        void CreateUser()
        {
            Console.WriteLine("Enter First Name:");
           string firstName= Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email Address:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Registration Number:");
            int.TryParse(Console.ReadLine(), out int registration);
            sweepstakesContestant = new Contestant(firstName,lastName,email,registration);
        }
    }
}
