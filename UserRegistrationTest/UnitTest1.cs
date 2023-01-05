using UserRegistrationAssignment;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameValidationTest1()
        {
            string name = "kiran";
            UserDetials user = new UserDetials();
            bool result = user.ValidateFirstname(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void FirstNameValidationTest2()
        {
            string name = "Kiran";
            UserDetials user = new UserDetials();
            bool result = user.ValidateFirstname(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameValidationTest1()
        {
            string name = "Reus";
            UserDetials user = new UserDetials();
            bool result = user.ValidateLastname(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void LastNameValidationTest2()
        {
            string name = "reus";
            UserDetials user = new UserDetials();
            bool result = user.ValidateLastname(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailValidationTest1()
        {
            string email = "Kiranreusmarco11@gmail.com";
            UserDetials user = new UserDetials();
            bool result = user.ValidateEmailAddress(email);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailValidationTest2()
        {
            string email = "Kiranreusmarco11@com";
            UserDetials user = new UserDetials();
            bool result = user.ValidateEmailAddress(email);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PhoneNumberValidationTest1()
        {
            string phn = "91 9343545445";
            UserDetials user = new UserDetials();
            bool result = user.Validatephonenumber(phn);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PhoneNumberValidationTest2()
        {
            string phn = "91 943545445";
            UserDetials user = new UserDetials();
            bool result = user.Validatephonenumber(phn);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordValidationTest1()
        {
            string pwd = "Marco11*";
            UserDetials user = new UserDetials();
            bool result = user.Validatepassword(pwd);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PasswordValidationTest2()
        {
            string pwd = "ReusMarco11";
            UserDetials user = new UserDetials();
            bool result = user.Validatepassword(pwd);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        [DataRow("MarcoBvb@gmail.com")]
        [DataRow("Reuslio.co.in")]
        [DataRow("LionelMessi10@barcelona.co.in")]
        public void ParamterizedEmailTest(string Email)
        {
            UserDetials user = new UserDetials();
            bool result = user.ValidateEmailAddress(Email);
            Assert.AreEqual(true, result);
        }
    }
}