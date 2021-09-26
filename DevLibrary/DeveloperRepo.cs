using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer
{
    //CRUD
        //Create
        //Read
        //Update
        //Delete
    public class DeveloperRepo
    {
        private readonly List<Developers> _developerDirectory = new List<Developers>();

        //Create
        public bool AddDeveloperToDirectory(Developers developer)
        {
            int startingCount = _developerDirectory.Count;

            _developerDirectory.Add(developer);

            bool wasAdded = (_developerDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read (GET)
        public List<Developers> GetDevelopers()
        {
            return _developerDirectory;
        }

        //Get By Employee Name
        public Developers GetDeveloperByName(string theDeveloperYouAreLookingFor)
        {
            foreach (Developers developer in _developerDirectory)
            {
                if (developer.Name.ToLower() == theDeveloperYouAreLookingFor.ToLower())
                {
                    return developer;
                }
            }
                    return null;
        }

        //Update
        public bool UpdateExistingDeveloper(Developers existingDeveloper, Developers newDeveloper)
        {
            if (existingDeveloper != null)
            {
                existingDeveloper.Name = newDeveloper.Name;
                existingDeveloper.IDNum = newDeveloper.IDNum;
                existingDeveloper.TeamName = newDeveloper.TeamName;
                existingDeveloper.Pluralsight = newDeveloper.Pluralsight;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteDeveloper(Developers existingDeveloper)
        {
            bool result = _developerDirectory.Remove(existingDeveloper);
            return result;
        }
    }
}
