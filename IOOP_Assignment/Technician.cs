using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Technician
    {
        //member field
        private string name, address, state, city, occupation;
        private int phoneNum, postcode;

        //constructor
        public Technician(string name, int phoneNum, string address, string state, string city, int postcode, string occupation)
        {
            this.name = name;
            this.phoneNum = phoneNum;
            this.address = address;
            this.state = state;
            this.city = city;
            this.postcode = postcode;
            this.occupation = occupation;
        }

        //member method
        public string printDetails()
        {
            return name + "\t" + "0"+phoneNum + "\t"+ address + "\t" + state +"\t" + city + "\t"+ 
                postcode + "\t" + occupation;
        }
    }
}
