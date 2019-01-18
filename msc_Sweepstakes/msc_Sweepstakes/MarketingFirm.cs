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
        string _name;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
           this.sweepstakesManager = sweepstakesManager; 
    }
        public void CreateSweepStakes()
        {
            Console.WriteLine("What is the name of your Sweepstake?");
             _name = Console.ReadLine();
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
        public void PrintAllContestants()
        {
            sweepstakes.PrintAllContestantsInfo();
        }
        public void SendNoticeToContesants()
        {
           string winner = sweepstakes.SendNoticeToContesants();
            foreach (var item in sweepstakes.Dictionary)
            {
                //name, email,winner,nameofsweepstakes
                SendEmail.EmailToSendAsync(item.Value.ConcatName, item.Value.Email, winner, _name);
            }
        }
    }
}
