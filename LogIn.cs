using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndConsole_Bank_App
{
  
    internal class LogIn
    {
        public void Log()
            {
            bool cond = true;
            UserInfo CharlesInfo = new UserInfo(); //Created info objects
            UserInfo JohnInfo = new UserInfo();
            UserInfo PaulInfo = new UserInfo();

            //Dictionary<string, string> Userss = new Dictionary<string, string>();
            //Userss.Add("carss", "Charles");
            //Userss.Add("trust", "Josh");
            //Userss.Add("fan", "Paul");

            var myList = new List<Users>();                  //List of Users
            myList.Add(new Users() { 
                Username = "Charles" , Password = "carss", Balance = 10007
            });
            myList.Add(new Users() { 
                Username = "John" , Password = "songs" , Balance = 51888
            });
            myList.Add(new Users() { 
                Username = "Paul" , Password = "truth" , Balance= 79300
            });
               

            Console.WriteLine("LOGIN SYNTAX");
            //Console.WriteLine("Enter Username: ");
            //string Username = Console.ReadLine();
            Console.Write("Enter username: ");
            string inputUsername = Console.ReadLine();

            // Check if the username exists in the list
            var user = myList.FirstOrDefault(u => u.Username == inputUsername);

            //do
            //{
                if (user != null)
                {
                    cond = true;
                    // If user exists, ask for the password
                    Console.Write($"Type in password for {user.Username}: ");
                    string inputPassword = Console.ReadLine();

                    // Check if the entered password matches the one in the list
                    if (user.Password == inputPassword)
                    {
                        Console.WriteLine("Login successful!");
                        Console.WriteLine("                 ");
                        Console.WriteLine("_________________");
                        Processes info = new Processes();
                    info.currentBalance(user , myList);
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("SEND MONEY < 1 >");
                        Console.WriteLine("WITHDRAW CASH < 2 >");
                        Console.WriteLine("MAKE A DEPOSIT < 3 >");
                        Console.WriteLine("CHECK BALANCE < 4 >");

                        Console.WriteLine("LOGOUT < 5 >");
                        string BankOpt = Console.ReadLine();

                        Processes processes = new Processes();

                    
                        switch (BankOpt)
                        {
                            case "1":
                                Console.WriteLine("                        ");
                                Console.WriteLine("                        ");
                                Console.WriteLine("                        ");

                                Console.WriteLine("SEND MONEY");

                                processes.Send(user, myList);
                                break;

                            case "2":
                                Console.WriteLine("WITHDRAW CASH");
                                Processes withdrawal = new Processes();
                                withdrawal.Withdraw(user, myList);



                                break;

                            case "3":
                                Console.WriteLine("MAKE A DEPOSIT");
                                Processes depo = new Processes();
                                depo.Deposit(user, myList);
                                break;

                            case "4":
                            Console.WriteLine("CURRENT BALANCE");
                            Processes check = new Processes();
                            check.currentBalance(user , myList);
                            Processes ink = new Processes();
                            ink.Continue(user, myList);
                            break ;


                            case "5":
                                Console.WriteLine("Logout");
                                Processes logout = new Processes();
                                logout.Logout(user, myList);
                                break;

                            default:
                            Console.WriteLine("INVALID INPUT");
                            What();
                           
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password.");
                        Console.WriteLine();
                        Log();
                        
                    }
                }
                else
                {
                    // If the username doesn't exist
                    Console.WriteLine("Username does not exist.");
                Console.WriteLine();
                Log();
                }

            
            //}
            //while (true);
            //return;
        }
        public void What()
        {
            bool cond = true;
            UserInfo CharlesInfo = new UserInfo(); //Created info objects
            UserInfo JohnInfo = new UserInfo();
            UserInfo PaulInfo = new UserInfo();

            //Dictionary<string, string> Userss = new Dictionary<string, string>();
            //Userss.Add("carss", "Charles");
            //Userss.Add("trust", "Josh");
            //Userss.Add("fan", "Paul");

            var myList = new List<Users>();                  //List of Users
            myList.Add(new Users()
            {
                Username = "Charles",
                Password = "carss",
                Balance = 10007
            });
            myList.Add(new Users()
            {
                Username = "John",
                Password = "songs",
                Balance = 51888
            });
            myList.Add(new Users()
            {
                Username = "Paul",
                Password = "truth",
                Balance = 79300
            });

            Console.WriteLine("LOGIN SYNTAX");
            //Console.WriteLine("Enter Username: ");
            //string Username = Console.ReadLine();
            Console.Write("Enter username: ");
            string inputUsername = Console.ReadLine();

            // Check if the username exists in the list
            var user = myList.FirstOrDefault(u => u.Username == inputUsername);



            if (user != null)
            {
                cond = true;
                // If user exists, ask for the password
                Console.Write($"Type in password for {user.Username}: ");
                string inputPassword = Console.ReadLine();

                // Check if the entered password matches the one in the list
                if (user.Password == inputPassword)
                {
                    Console.WriteLine("Login successful!");
                    Console.WriteLine("                 ");
                    Console.WriteLine("_________________");
                    Processes info = new Processes();
                    info.currentBalance(user, myList);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("SEND MONEY < 1 >");
                    Console.WriteLine("WITHDRAW CASH < 2 >");
                    Console.WriteLine("MAKE A DEPOSIT < 3 >");

                    Console.WriteLine("LOGOUT < 4 >");
                    string BankOpt = Console.ReadLine();

                    Processes processes = new Processes();


                    switch (BankOpt)
                    {
                        case "1":
                            Console.WriteLine("                        ");
                            Console.WriteLine("                        ");
                            Console.WriteLine("                        ");

                            Console.WriteLine("SEND MONEY");

                            processes.Send(user, myList);
                            break;

                        case "2":
                            Console.WriteLine("WITHDRAW CASH");
                            Processes withdrawal = new Processes();
                            withdrawal.Withdraw(user, myList);



                            break;

                        case "3":
                            Console.WriteLine("MAKE A DEPOSIT");
                            Processes depo = new Processes();
                            depo.Deposit(user, myList);
                            break;

                        case "4":
                            Console.WriteLine("Logout");
                            Processes logout = new Processes();
                            logout.Logout(user, myList);
                            break;

                        default:
                            Console.WriteLine("INVALID INPUT");
                            What(); //continue syntax

                          
                            
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                    Console.WriteLine();
                    Log();

                }
            }
            else
            {
                // If the username doesn't exist
                Console.WriteLine("Username does not exist.");
                Console.WriteLine();
                Log();
            }
        }

    }

}
    

