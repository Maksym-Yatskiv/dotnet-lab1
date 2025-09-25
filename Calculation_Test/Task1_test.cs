using dotnet_labs.lab3;
namespace Calculation_Test
{
    [TestClass]
    public sealed class Task1_test
    {
        [TestMethod]
        public void Calculate_NoMultiplesOf7_ReturnsZero()
        {
            var task = new CalculationTask1(1, 2, 3);

            int result = task.Calculate();

            Assert.AreEqual(0.0, result);
        }

        [TestMethod]
        public void Calculate_SomeMultiplesOf7_ReturnsSumOfCubes()
        {
            var task = new CalculationTask1(7, 14, 1);

            int expected = 343 + 2744;
            int result = task.Calculate();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_AllMultiplesOf7_ReturnsSumOfAllCubes()
        {
            var task = new CalculationTask1(7, 21, 28);

            int expected = 7 * 7 * 7 + 21 * 21 * 21 + 28 * 28 * 28;
            int result = task.Calculate();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NegativeMultiplesHandledCorrectly()
        {
            var task = new CalculationTask1(-7, 0, 5);

            int expected = (-7) * (-7) * (-7) + 0;
            int result = task.Calculate();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DefaultConstructor_ValuesAreZero_CalculateReturnsZero()
        {
            var task = new CalculationTask1();
            int result = task.Calculate();
            Assert.AreEqual(0.0, result);
        }
    }
}
