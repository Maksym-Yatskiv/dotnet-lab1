using dotnet_labs.lab3;

namespace Calculation_Test;

[TestClass]
public class Task2_test
{
    [TestMethod]
    public void Calculate_AEqualsB_ReturnsZero()
    {
        var task = new CalculationTask2(77, 77);
        int result = task.Calculate();
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Calculate_NoMatchingNumbers_ReturnsZero()
    {
        var task = new CalculationTask2(1, 50);
        int result = task.Calculate();
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void Calculate_WithMatchingNumbers_ReturnsCorrectSum()
    {
        var task = new CalculationTask2(10, 200);
        int result = task.Calculate();
        Assert.AreEqual(242, result);
    }

    [TestMethod]
    public void Calculate_WithMatchingNumbers_ReturnsCorrectSum_LargerRange()
    {
        var task = new CalculationTask2(10, 400);
        int result = task.Calculate();
        Assert.AreEqual(836, result);
    }

    [TestMethod]
    public void Calculate_NegativeRange_WorksCorrectly()
    {
        var task = new CalculationTask2(-200, 0);
        int result = task.Calculate();
        Console.WriteLine(result);
        Assert.AreEqual(-297, result);
    }
}
