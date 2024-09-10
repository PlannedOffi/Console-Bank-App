namespace _2ndConsole_Bank_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<Users>();                  //List of Users
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

            UserInfo CharlesInfo = new UserInfo(); //Created info objects
            UserInfo JohnInfo = new UserInfo();
            UserInfo PaulInfo = new UserInfo(); //Created Info Objects

            bool cond;

                Console.WriteLine("WELCOME TO CONSOLE BANK");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine("Would you like to proceed? (Select Y/N)");
                string option = Console.ReadLine().ToUpper();
                //continuation code, if else if statement used
                do
                {
                    if (option == "Y")
                    {
                        Console.WriteLine("...");


                        Console.WriteLine("Bank Options");
                        Console.WriteLine("____________");
                        Console.WriteLine("To LogIn to an Already Existing Account,  Type < 1 >");
                        Console.WriteLine("To Create Account,  Type < 2 >");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("You selected Option < 1 >....LogIn");
                                LogIn Loginsss = new LogIn();
                                Loginsss.Log();

                                return;

                            case "2":
                                Console.WriteLine("You selected Option < 2 >....Create Account");
                                CreateAcc ACCT_Create = new CreateAcc();
                                ACCT_Create.CreateAccount(myList);

                                break;

                            default:
                                Console.WriteLine("Invalid Option");
                                Console.WriteLine("Please select an option from the list");

                                break;

                        }



                    }
                    else if (option == "N")
                    {
                        Console.Write("Process Terminated");
                        break;
                        //return;   //terminate if n is chosen
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                        //cond = false;   //terminate if anything else is chosen and give error message
                        //return;
                    }

                }
                while (true);






        }
    }
}
