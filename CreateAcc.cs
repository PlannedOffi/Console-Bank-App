using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndConsole_Bank_App
{
    internal class CreateAcc
    {
     

            public void CreateAccount(List<Users> userList)
            {
            var myList = new List<Users>();                  //List of Users
            myList.Add(new Users()
            {
                Username = "Charles",
                Password = "carss" ,
                Balance  = 10007
            });
            myList.Add(new Users()
            {
                Username = "John",
                Password = "songs" ,
                Balance  = 51888
            });
            myList.Add(new Users()
            {
                Username = "Paul",
                Password = "truth" ,
                Balance = 79300
            });

            Console.WriteLine("---- Create a New Account ----");
                Console.Write("Enter a new username: ");
                string newUsername = Console.ReadLine();

                // Check if the username already exists
                var existingUser = myList.FirstOrDefault(u => u.Username == newUsername);
                if (existingUser != null)
                {
                    Console.WriteLine("Username already exists. Please try a different username.");
                    return;
                }

                // Ask for a password
                Console.Write("Enter a password: ");
                string newPassword = Console.ReadLine();

                // Add the new user to the list
                myList.Add(new Users { Username = newUsername, Password = newPassword , Balance = 0});
                Console.WriteLine("Account created successfully!");
                Console.WriteLine("_____________________________");
                Console.WriteLine("Log into Account?  < 1 > ");
                Console.WriteLine("Exit  < 2 > ");
                
                

                switch (Console.ReadLine())
            {
                case "1":
                    LogIn login = new LogIn();
                    login.Log();
                    break;

                    case "2":
                    Console.WriteLine("GoodBye!");
                    break;
            }
            }

       
    }
}
