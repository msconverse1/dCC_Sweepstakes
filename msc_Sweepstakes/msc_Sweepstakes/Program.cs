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
            SweepstakesQueueManager Queue = new SweepstakesQueueManager();
            MarketingFirm marketingFirm = new MarketingFirm(Queue);
            marketingFirm.CreateSweepStakes();
            marketingFirm.AddToManager();
        }
    }
}
