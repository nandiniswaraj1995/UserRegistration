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
            bool result = pattern.isValidFirstName("swaraj");
            Assert.AreEqual(false, result);
        }

    }
}