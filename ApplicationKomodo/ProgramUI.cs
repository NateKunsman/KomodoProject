using Developer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationKomodo
{
    class ProgramUI
    {
        private DeveloperRepo _repo = new DeveloperRepo();
        public void Run()
        {
            SeedData();

            RunMenu();

        }

        private void RunMenu()
        {
            //This should create a menu with options matching up to my repository

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine
                    (
                    "Enter the number of your selection: \n" +
                    "1. Create new user\n" +
                    "2. Show all users\n" +
                    "3. Find user by name\n" +
                    "4. Update user info\n" +
                    "5. Delete user\n" +
                    "6. Show Users needing Pluralsight access\n" +
                    "0. Exit"
                    );
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Creates new user/developer
                        CreateNewDeveloper();
                        break;
                    case "2":
                        //Show all users/developers
                        ShowAllUsers();
                        break;
                    case "3":
                        //Show user/developer by name
                        ShowUserByName();
                        break;
                    case "4":
                        //Update user/developer
                        break;
                    case "5":
                        //Delete user/developer
                        break;
                    case "6":
                        //Users Needing Pluralsight
                        ShowAllDevelopersWithoutPluralsight();
                        break;
                    case "0":
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Enter a valid number between 1 and 6\n" +
                            "Press any key to continue");
                        Console.ReadLine();
                        Console.ReadKey();
                        break;
                }
            }
        }
        //Creating a user

        private void CreateNewDeveloper()
        {
            Console.Clear();

            Developers developer = new Developers();

            //Name
            Console.WriteLine("Please enter first and last name of user with space inbetween\n" +
                "Press Enter when complete");
            developer.Name = Console.ReadLine();

            //User ID
            Console.WriteLine("Please enter user's ID\n" +
                "Press Enter when complete");
            developer.IDNum = Console.ReadLine();

            //User's Team
            Console.WriteLine("Please enter user's assigned team\n" +
                "Press Enter when complete");
            developer.TeamName = Console.ReadLine();

            //Pluralsight Access         ////Find a fix////
            Console.WriteLine("Please enter 'true' or 'false' for user's Pluralsight access\n" +
                "Press Enter when complete");
            string userInput = Console.ReadLine().ToLower();
            
            

            _repo.AddDeveloperToDirectory(developer);

        }

        //Retreive all users

        private void ShowAllUsers()
        {
            Console.Clear();

            List<Developers> listOfDevelopers = _repo.GetDevelopers();

            foreach(Developers developer in listOfDevelopers)
            {
                //add helper method
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        //Retrieving specific user (by Name)
        private void ShowUserByName()
        {
            Console.Clear();

            Console.WriteLine("Which User are you looking for?");
            string name = Console.ReadLine();

            Developers developer = _repo.GetDeveloperByName(name);
            //verify that user/developer is in repository
            //Using helper method
            //add helper method
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        //Retreive Users needing Pluralsight license
        private void UsersNeedingPluralsightLicense()
        {
            Console.Clear();
            Console.WriteLine("Here are developers still needing a Pluralsight license");

            List<Developers> allDevelopers = _repo.GetDevelopers();
            bool needLicense = false;
            foreach (Developers developer in allDevelopers)
            {
                if (developer.Pluralsight == false)
                {
                    Console.WriteLine($"{needLicense}. Name: {developer.Name}\n" +
                        $" ID: {developer.IDNum}\n\n");
                }
            }
        }

        //Update Content

        //Delete content

        //Access to Pluralsight
        private void ShowAllDevelopersWithoutPluralsight()
        {
            Console.Clear();
            Console.WriteLine();
            List<Developers> listOfDevelopers = _repo.GetDevelopers();

            foreach(Developers developer in listOfDevelopers)
            {
                if(developer.Pluralsight == false)
                {
                    DisplayDeveloper(developer);
                }
            }
        }

        //Helper Methods
        private void DisplayDeveloper(Developers developer)
        {
            Console.WriteLine(
                $"Name: { developer.Name}\n" +
                $"UserID { developer.IDNum}\n" +
                $"UserTeam: { developer.TeamName}\n" +
                $"Pluralsight Access { developer.Pluralsight}\n\n");
        }
        //Exit
        
        //Preset Users
        private void SeedData()
        {
            Developers JaneDoe = new Developers("Jane Doe", "52000001", "UX Team", false);
            Developers MikeByrne = new Developers("Mike Byrne", "52000002", "UX Team", true);
            Developers AlexKunts = new Developers("Alex Kunts", "52000003", "Developer Team", false);
            Developers SamAnderson = new Developers("Sam Anderson", "52000004", "Developer Team", false);

            _repo.AddDeveloperToDirectory(JaneDoe);
            _repo.AddDeveloperToDirectory(MikeByrne);
            _repo.AddDeveloperToDirectory(AlexKunts);
            _repo.AddDeveloperToDirectory(SamAnderson);
        }
    }
}

