using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
       
        [TestMethod]
        public void Given_First_Name_Should_Returrns_True()
        {
            bool result = pattern.isValidFirstName("Nandini");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Given_First_Name_Should_Returrns_False()
        {
            bool result = pattern.isValidFirstName("nandini");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Given_Last_Name_Should_Returrns_True()
        {
            bool result = pattern.isValidLastName("Swaraj");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Given_Last_Name_Should_Returrns_False()
        {
            bool result = pattern.isValidLastName("swaraj");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Given_Email_Should_Returrns_True()
        {
            bool result = pattern.isValidEmail("abc.xyz@bl.co.in");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Given_Email_Should_Returrns_False()
        {
            bool result = pattern.isValidEmail("abc.@gmail.com.com.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Given_Mobile_Should_Returrns_True()
        {
            bool result = pattern.isValidMobileNumber("91 9876543210");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Given_Mobile_Should_Returrns_False()
        {
            bool result = pattern.isValidMobileNumber("67891234567");
            Assert.AreEqual(false, result);
        }



    }
}
