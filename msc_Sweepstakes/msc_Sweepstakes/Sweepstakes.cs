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
        public Dictionary<int, Contestant> Dictionary { get => dictionary; }
        Random Random = new Random();
        readonly string SweepstakesName;
        string winner;
        public Sweepstakes(string name)
        {
            SweepstakesName = name;
        }
        public void CreateContestant()
        {
            RegisterContestant(UserInterface.CreateUser(dictionary, Random));
        }

        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.Registration, contestant);
        }
        string PickWinner()
        {
            string temp = "No Winner";
            int winningKey = Random.Next(dictionary.Keys.Min(), dictionary.Keys.Max());
            if (dictionary.Keys.Contains(winningKey))
            {
                temp = dictionary[winningKey].ConcatName;
            }
            return temp;
        }
        string PrintContestantInfo(Contestant contestant)
        {
            winner = PickWinner();
            if (contestant.ConcatName == winner)
            {
                Console.WriteLine("The Winner of {0} ", SweepstakesName);
                Console.WriteLine("Winning Contestant is {0}. There email: {1}.", contestant.ConcatName, contestant.Email);
            }
            return winner;
        }
        public void PrintAllContestantsInfo()
        {
            int i = 0;
            foreach (var item in dictionary)
            {
              
                Console.WriteLine("Name of Contestants {1} : {0}", item.Value.ConcatName, i);
                Console.WriteLine("Email of Contestants {1} : {0}", item.Value.Email, i);
                Console.WriteLine("Registration of Contestants {1} : {0}", item.Value.Registration, i);
                i++;
            }
        }
        public string SendNoticeToContesants()
        {
          return  winner = PickWinner();  
        }
    }
}
