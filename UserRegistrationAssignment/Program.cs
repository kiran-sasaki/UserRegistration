namespace UserRegistrationAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserDetials user = new UserDetials();
            //UC1
            Console.WriteLine("please enter Firstname");
            List<string> firstName = new List<string>() { "kiran" };
            bool fname = user.ValidateFirstName(firstName);
            if (fname)
                Console.WriteLine("Firstname Matched");
            else
                Console.WriteLine("FirstName not matched");
            ////UC2
            //Console.WriteLine("please enter LastName");
            //string lastName = Console.ReadLine();
            //bool Lname = user.ValidateLastname(lastName);
            //if (Lname)
            //    Console.WriteLine("Lastname Matched");
            //else
            //    Console.WriteLine("LastName not matched");
            ////UC3
            //Console.WriteLine("please enter The EmailAdress: ");
            //string Emailaddress = Console.ReadLine();

            //bool Email = user.ValidateEmailAddress(Emailaddress);
            //if (Email)
            //    Console.WriteLine("Email Matched");
            //else
            //    Console.WriteLine("Email not matched");
            ////UC4
            //Console.WriteLine("please enter PhoneNumber");
            //string phonenumber = Console.ReadLine();
            //bool PhnNO = user.Validatephonenumber(phonenumber);
            //if (PhnNO)
            //    Console.WriteLine("Phn Number Matched");
            //else
            //    Console.WriteLine("Phn Number not matched");
            ////UC5
            //Console.WriteLine("please enter PassWord: ");
            //string passWord = Console.ReadLine();
            //bool pwd = user.Validatepassword(passWord);
            //if (pwd)
            //    Console.WriteLine("Password Matched");
            //else
            //    Console.WriteLine("Password not matched");
        }
    }
}