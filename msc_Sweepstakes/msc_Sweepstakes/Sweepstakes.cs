using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        HashSet<int> Registration = new HashSet<int>();
        Random Random = new Random();
        readonly string SweepstakesName;
        UserInterface UserInterface = new UserInterface();
       public Sweepstakes(string name)
        {
            SweepstakesName = name;
        }
        public void CreateContestant()
        {
           RegisterContestant(UserInterface.CreateUser(Registration,dictionary, Random));
        }

      public  void RegisterContestant(Contestant contestant)
        {

            dictionary.Add(contestant.Registration, contestant);
        }
        string PickWinner()
        {
            string temp = "placeholder";
           int winningKey= Random.Next(dictionary.Keys.Min(), dictionary.Keys.Max());
            if (dictionary.Keys.Contains(winningKey))
            {
                temp = dictionary[winningKey].ConcatName;
            }
            return temp;
        }
        void PrintContestantInfo(Contestant contestant)
        {
            if (contestant.ConcatName == PickWinner())
            {
                Console.WriteLine("The Winner of {0} ",SweepstakesName);
                Console.WriteLine("Winning Contestant is {0}. There email: {1}.", contestant.ConcatName, contestant.Email);
            }
        }
    }
}
