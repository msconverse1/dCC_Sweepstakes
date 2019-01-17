using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sweepstakes sweepstakes = new Sweepstakes("Test");
            for (int i = 0; i < 3; i++)
            {
                sweepstakes.CreateContestant();
                Console.WriteLine("Press any ket to continue!");
                Console.ReadLine();
                Console.Clear();
            }
            sweepstakes.PrintAllContestantsInfo();
            Console.ReadLine();
        }
    }
}
