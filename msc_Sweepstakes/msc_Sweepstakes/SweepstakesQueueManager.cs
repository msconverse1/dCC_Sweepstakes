using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> Sweepstakes = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return Sweepstakes.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Sweepstakes.Enqueue(sweepstakes);
        }
    }
}
