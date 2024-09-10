//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _2ndConsole_Bank_App
{
    internal class Processes
    {
        public void Send(Users sender, List<Users> myList)

        {

            myList.Add(new Users()
            {
                Username = "Charles",
                Password = "carss"
            });
            myList.Add(new Users()
            {
                Username = "John",
                Password = "songs"
            });
            myList.Add(new Users()
            {
                Username = "Paul",
                Password = "truth"
            });

            Console.Write("Enter Recipient UserName:  ");

            string beneficiary = Console.ReadLine();

            var recipient = myList.FirstOrDefault(u => u.Username == beneficiary && beneficiary != sender.Username); // check if beneficiary exists
            if (recipient != null)
            {
                Console.WriteLine("Enter Amount To Send to " + beneficiary + " here:");
                if (double.TryParse(Console.ReadLine(), out double transferAmount))
                {
                    // Validate if sender has enough balance
                    if (sender.Balance >= transferAmount)
                    {
                        // Perform the transfer
                        sender.Balance -= transferAmount;
                        recipient.Balance += transferAmount;

                        Console.WriteLine("Successfully sent " + transferAmount + "  to " + beneficiary);
                        Console.WriteLine(sender.Username + "  new balance: " + sender.Balance);
                        Console.WriteLine();
                        Continue(sender, myList);

                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds to complete the transfer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount entered.");
                }
            }
            else
            {
                // If the username doesn't exist
                Console.WriteLine("User does not exist or Cannot send to yourself");
                Send(sender, myList);
            }

        }
        public void Withdraw(Users sender, List<Users> myList)
        {
            Console.WriteLine("HOW MUCH CASH WOULD YOU LIKE TO WITHDRAW? : ");
            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
            {
                if (sender.Balance >= withdrawAmount)
                {
                    sender.Balance -= withdrawAmount;
                    Console.WriteLine(withdrawAmount + " was succesfully withdrawn!");
                    Console.WriteLine(sender.Username + "  new balance: " + sender.Balance);
                    Console.WriteLine();

                    Continue(sender, myList);
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }

            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }

        }

        public void Deposit(Users sender, List<Users> myList)
        {
            Console.WriteLine("HOW MUCH CASH WOULD YOU LIKE TO DEPOSIT? : ");
            if (double.TryParse(Console.ReadLine(), out double depoAmount))
            {

                sender.Balance += depoAmount;
                Console.WriteLine(depoAmount + " was succesfully deposited!");
                Console.WriteLine(sender.Username + "  new balance: " + sender.Balance);
                Console.WriteLine();

                Continue(sender, myList);


            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void Logout(Users user, List<Users> myList)
        {
            Console.WriteLine("Logged Out Successfully of " + user.Username);
            return;

        }

        public void Continue(Users user, List<Users> myList)
        {
            Console.WriteLine("Would you like to peform more operations on " + user.Username);
            Console.WriteLine("YES < 1 >");
            Console.WriteLine("NO < 2 >");

            switch ((Console.ReadLine()))
            {
                case "1":
                    LogIn relogin = new LogIn();
                    relogin.Log();
                    break;

                case "2":
                    Console.WriteLine(" END OF SESSION");
                    break;

            }
        }

        public void currentBalance(Users sender, List<Users> myList)
        {
            Console.WriteLine(sender.Username + " currently has " + sender.Balance);
        }

    }
}
