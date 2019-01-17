using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> Stack =new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return Stack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Stack.Push(sweepstakes);
        }
    }
}
