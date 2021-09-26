using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    public class Developers
    {
        public Developers() { }
        public Developers(string name, string idNum, string teamName, bool pluralsight)
        {
            Name = name;
            IDNum = idNum;
            TeamName = teamName;
            Pluralsight = pluralsight;
        }
        public string Name { get; set; }
        public string IDNum { get; set; }
        public string TeamName { get; set; }
        public bool Pluralsight { get; set; }
       
    }
}
