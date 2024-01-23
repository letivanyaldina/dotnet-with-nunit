namespace PrimeService.Tests;

public class CalculatorTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 4);

        // Assert
        Assert.AreEqual(7, result);
    }
}