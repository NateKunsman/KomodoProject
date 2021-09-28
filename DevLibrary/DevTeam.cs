using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevLibrary
{
    public class DevTeam
    {
        public DevTeam() { }
        public DevTeam(string teamName, string teamID, List<Developers> addDeveloperToTeam)
        {
            TeamName = teamName;
            TeamID = teamID;
            AddDeveloperToTeam = addDeveloperToTeam;
        }
        public string TeamName { get; set; }
        public string TeamID { get; set; }
        public List<Developers> AddDeveloperToTeam { get; set; }
    }
}
