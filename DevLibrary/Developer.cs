using System;

namespace Developer
{
    public class Developer
    {
        public Developer() { }
        public Developer(string name, string idNum, string teamName, bool pluralsight)
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
