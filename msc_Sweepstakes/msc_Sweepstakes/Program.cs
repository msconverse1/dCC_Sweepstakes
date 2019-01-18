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
            ISweepstakesManager sweepstakesManager;
            sweepstakesManager= UserInterface.ChooseManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepStakes();
            marketingFirm.AddToManager();
            marketingFirm.ChooseWinner();
        }
    }
}
