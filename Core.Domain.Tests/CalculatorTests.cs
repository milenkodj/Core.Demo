using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Domain.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var calc = new Calculator();

            Assert.AreEqual(2, calc.Add(1, 1));
        }
    }
}
