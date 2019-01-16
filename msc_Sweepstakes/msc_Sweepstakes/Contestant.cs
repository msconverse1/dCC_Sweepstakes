using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msc_Sweepstakes
{
    class Contestant
    {
        string firstName;
        string lastName;
        string email;
        int registration;
        public Contestant(string firstName,string lastName,string email,int registration)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registration = registration;
        }
    }
}
