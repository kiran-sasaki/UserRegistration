namespace UserRegistrationAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserDetials user = new UserDetials();
            Console.WriteLine("please enter Firstname");
            string firstName = Console.ReadLine();

            bool Fname = user.ValidateFirstname(firstName);
            if (Fname)
                Console.WriteLine("firstname Matched");
            else
                Console.WriteLine("FirstName not matched");
        }
    }
}