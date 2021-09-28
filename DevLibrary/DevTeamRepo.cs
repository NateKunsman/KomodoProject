using DevLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    //CRUD
        //Create
        //Read
        //Update
        //Delete
    public class DevTeamRepo
    {
        private readonly List<DevTeam> _devTeamDirectory = new List<DevTeam>();

        //Create
        public bool AddDevTeamToDirectory(DevTeam devTeam)
        {
            int startingcount = _devTeamDirectory.Count;
            _devTeamDirectory.Add(devTeam);
            bool wasAdded = (_devTeamDirectory.Count > startingcount) ? true : false;
            return wasAdded;
        }
        //Read (Get)
        public List<DevTeam> GetDevTeams()
        {
            return _devTeamDirectory;
        }

        //Get Team by TeamName
        public DevTeam GetDevTeamByDevTeamName(string theTeamYouAreLookingFor)
        {
            foreach (DevTeam devTeam in _devTeamDirectory)
            {
                if (devTeam.TeamName.ToLower() == theTeamYouAreLookingFor.ToLower())
                {
                    return devTeam;
                }
            }
                    return null;
        }
        //Update Team
        public bool UpdateExistingTeam(DevTeam existingDevTeam, DevTeam newDevTeam)
        {
            if (existingDevTeam != null)
            {
                existingDevTeam.TeamName = newDevTeam.TeamName;
                existingDevTeam.TeamID = newDevTeam.TeamID;
                existingDevTeam.AddDeveloperToTeam = newDevTeam.AddDeveloperToTeam;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete Team
        public bool DeleteDevTeam(DevTeam existingDevTeam)
        {
            bool result = _devTeamDirectory.Remove(existingDevTeam);
            return result;
        }
    }
}
