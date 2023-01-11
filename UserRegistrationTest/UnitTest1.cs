using UserRegistrationAssignment;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameValidationTest1()
        {
            try
            {
                List<string> firstname = new List<string>() {"kiran"};
                UserDetials user = new UserDetials();
                bool result = user.ValidateFirstName(firstname);
                Assert.AreEqual(true, result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void FirstNameValidationTest2()
        {
            List<string> firstname = new List<string>() { "Kiran","reus" };
            UserDetials user = new UserDetials();
            bool result = user.ValidateFirstName(firstname);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameValidationTest1()
        {
            List<string> lastname = new List<string>() { "Messi" };
            UserDetials user = new UserDetials();
            bool result = user.ValidateLastName(lastname);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameValidationTest2()
        {
            try
            {
                List<string> lastname = new List<string>() { "lionel" };
                UserDetials user = new UserDetials();
                bool result = user.ValidateLastName(lastname);
                Assert.AreEqual(true, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void EmailValidationTest1()
        {
            List<string> email = new List<string>() { "reusmarco11@gmail.com" };
            UserDetials user = new UserDetials();
            bool result = user.ValidateEmailAddress(email);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailValidationTest2()
        {
            try
            {
                List<string> email = new List<string>() { "crmarco11.com.rf" };
                UserDetials user = new UserDetials();
                bool result = user.ValidateEmailAddress(email);
                Assert.AreEqual(true, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void PhoneNumberValidationTest1()
        {
            List<string> phn = new List<string>() { "91 6575345434" };
            UserDetials user = new UserDetials();
            bool result = user.ValidatePhoneNumber(phn);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PhoneNumberValidationTest2()
        {
            try
            {
                List<string> phn = new List<string>() { "91 5657534543454" };
                UserDetials user = new UserDetials();
                bool result = user.ValidatePhoneNumber(phn);
                Assert.AreEqual(true, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]
        public void PasswordValidationTest1()
        {
            List<string> pwd = new List<string>() { "Reusmr12*" };
            UserDetials user = new UserDetials();
            bool result = user.ValidatePassword(pwd);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordValidationTest2()
        {
            try
            {
                List<string> pwd = new List<string>() { "feusmao12*" };
                UserDetials user = new UserDetials();
                bool result = user.ValidatePassword(pwd);
                Assert.AreEqual(true, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //[TestMethod]
        //[DataRow("MarcoBvb@gmail.com")]
        //[DataRow("Reuslio.co.in")]
        //[DataRow("LionelMessi10@barce")]
        //public void ParamterizedEmailTest(List<string> Email)
        //{
        //    try
        //    {
        //        UserDetials user = new UserDetials();
        //        bool result = user.ValidateEmailAddress(Email);
        //        Assert.AreEqual(true, result);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    }
}