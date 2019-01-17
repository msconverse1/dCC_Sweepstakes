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

        public Sweepstakes()
        {

        }

        Sweepstakes(string name)
        {

        }
      public  void RegisterContestant(Contestant contestant)
        {
            do
            {
                int number = Random.Next(dictionary.Count, 999999);
                if (!Registration.Contains(number))
                {
                    Registration.Add(number);
                }
            } while (dictionary.Count > Registration.Count);
            UserInterface userInterface = new UserInterface();
            userInterface.CreateUser(contestant,Registration);
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

        }
    }
}
