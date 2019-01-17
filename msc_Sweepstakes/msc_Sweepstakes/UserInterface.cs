using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class UserInterface
    {
        
        public Contestant CreateUser(HashSet<int> Registration, Dictionary<int, Contestant> dictionary,Random random)
        {
            Contestant sweepstakesContestant;
            do
            {
                int number = random.Next(dictionary.Count, 999999);
                Registration.Add(number);
            } while (dictionary.Count > Registration.Count);
          int ran = random.Next(Registration.Min(), Registration.Max());
            Console.WriteLine("Enter First Name:");
           string firstName= Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email Address:");
            string email = Console.ReadLine();
            Console.WriteLine("Your Registration Number: {0}",ran);
            
          return sweepstakesContestant = new Contestant(firstName,lastName,email,ran);
        }
    }
}
