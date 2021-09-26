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
                    "1. Create new user" +
                    "2. Show all users" +
                    "3. Find user by name" +
                    "4. Update user info" +
                    "5. Delete user" +
                    "6. Exit"
                    );
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //Creates new user/developer
                        break;
                    case "2":
                        //Show all users/developers
                        break;
                    case "3":
                        //Show user/developer by name
                        break;
                    case "4":
                        //Update user/developer
                        break;
                    case "5":
                        //Delete user/developer
                        break;
                    case "6":
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

            
        }
        private void SeedData()
        {
            Developer      
        }
    }
}
