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
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Create
        public bool AddDeveloperToDirectory(Developer developer)
        {
            int startingCount = _developerDirectory.Count;

            _developerDirectory.Add(developer);

            bool wasAdded = (_developerDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read (GET)
        public List<Developer> GetDevelopers()
        {
            return _developerDirectory;
        }

        //Get By Employee Name
        public Developer GetDeveloperByName(string theDeveloperYouAreLookingFor)
        {
            foreach (Developer developer in _developerDirectory)
            {
                if (developer.Name.ToLower() == theDeveloperYouAreLookingFor.ToLower())
                {
                    return developer;
                }
            }
                    return null;
        }

        //Update
        public bool UpdateExistingDeveloper(Developer existingDeveloper, Developer newDeveloper)
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
        public bool DeleteDeveloper(Developer existingDeveloper)
        {
            bool result = _developerDirectory.Remove(existingDeveloper);
            return result;
        }
    }
}
