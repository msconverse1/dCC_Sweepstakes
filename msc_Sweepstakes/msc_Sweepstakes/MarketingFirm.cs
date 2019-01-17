using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
        Sweepstakes sweepstakes;
       
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
           this.sweepstakesManager = sweepstakesManager; 
    }
        public void CreateSweepStakes()
        {
            Console.WriteLine("What is the name of your Sweepstake?");
            string _name = Console.ReadLine();
           sweepstakes = new Sweepstakes(_name);
            Console.WriteLine("How Many Contestants are there in this contest?");
            int.TryParse(Console.ReadLine(),out int number);
            for (int i = 0; i < number; i++)
            {
                sweepstakes.CreateContestant();
            }
            
            //sweepstakes.PrintAllContestantsInfo();
            //Console.ReadLine();
        }
        public void AddToManager()
        {
            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }

    }
}
