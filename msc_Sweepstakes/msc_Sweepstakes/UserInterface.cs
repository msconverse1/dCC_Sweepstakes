using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
  static  class UserInterface
    {
        
       static public Contestant CreateUser( Dictionary<int, Contestant> dictionary,Random random)
        {
            Contestant sweepstakesContestant;
            int number = RegistrationGenerator(dictionary,random);
            Console.WriteLine("Enter First Name:");
           string firstName= Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email Address:");
            string email = Console.ReadLine();
            Console.WriteLine("Your Registration Number: {0}", number);
          return sweepstakesContestant = new Contestant(firstName,lastName,email, number);
        }

        private static int RegistrationGenerator(Dictionary<int, Contestant> dictionary, Random random)
        {
            int number;
            int maxvalue = 4;
            do
            {
                if (dictionary.Count == maxvalue)
                {
                    maxvalue *= maxvalue;
                }
                number = random.Next(maxvalue);    
            } while (dictionary.Keys.Contains(number));
            return number;
        }
    }
}
