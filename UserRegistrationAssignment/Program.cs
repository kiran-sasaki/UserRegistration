namespace UserRegistrationAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserDetials user = new UserDetials();
            //UC1
            Console.WriteLine("please enter Firstname");
            string firstName = Console.ReadLine();
            bool Fname = user.ValidateFirstname(firstName);
            if (Fname)
                Console.WriteLine("firstname Matched");
            else
                Console.WriteLine("FirstName not matched");
            //UC2
            Console.WriteLine("please enter LastName");
            string lastName = Console.ReadLine();
            bool Lname = user.ValidateLastname(lastName);
            if (Lname)
                Console.WriteLine("Lastname Matched");
            else
                Console.WriteLine("LastName not matched");
        }
    }
}