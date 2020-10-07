using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ReverseTests
    {
        [DataTestMethod]
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(120, 21)]
        [DataRow(0, 0)]
        public void ReverseTest(int input, int result)
        {
            var driver = new _Reverse();
            Assert.AreEqual(result, driver.Reverse(input));
        }
    }
}
