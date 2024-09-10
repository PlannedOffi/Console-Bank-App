namespace _2ndConsole_Bank_App
{
    public class UserInfo
    {

        public void DisplayUserInfo(string username)
        {
            switch (username)
            {
                case "Charles":
                    CharlesInfo();
                    break;
                case "John":
                    JohnInfo();
                    break;
                case "Paul":
                    PaulInfo();
                    break;
                default:
                    Console.WriteLine("No information available for this user.");
                    break;
            }
        }
        public void CharlesInfo(double Amount = 10007, string Name = "Charles")
        {
            Console.WriteLine("Charles");
            Console.WriteLine("Balance: " + Amount);
        }
        public void JohnInfo(double Amount = 51888, string Name = "John")
        {
            Console.WriteLine("John");
            Console.WriteLine("Balance: " + Amount);
        }
        public void PaulInfo(double Amount = 79300, string Name = "Paul")
        {
            Console.WriteLine("Paul");
            Console.WriteLine("Balance: " + Amount);
        }
    }
}
