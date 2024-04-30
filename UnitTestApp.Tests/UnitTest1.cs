using System;
using UnitTestApp.Controllers;
using Xunit;

public class CalculatorTests
{
    // правильная ли сумма
    [Fact]
    public void SumNumbers_ReturnsCorrectSum_WhenValidInput()
    {
        // Arrange
        var numbers = "3,8,4,2,7";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(24, result);
    }

    // игнор чисел > 10 при вычисление суммы
    [Fact]
    public void SumNumbers_IgnoresNumbersGreaterThan10()
    {
        // Arrange
        var numbers = "3,8,11,2,7";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(20, result);
    }

    // суммирование только первых 5 чисел
    [Fact]
    public void SumNumbers_OnlySumFirstFiveNumbers()
    {
        // Arrange
        var numbers = "3,8,4,2,7,9,11";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(24, result);
    }

    // если отриц. число - 0
    [Fact]
    public void SumNumbers_ReturnsZero_WhenNegativeNumberPresent()
    {
        // Arrange
        var numbers = "3 -8 -4 -2 7";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    // пустая строка - 0
    [Fact]
    public void SumNumbers_ReturnsZero_WhenEmptyString()
    {
        // Arrange
        var numbers = "";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(0, result);
    }

    // суммирование чисел с пользовательским разделителем
    [Fact]
    public void SumNumbers_CanUseCustomDelimiter()
    {
        // Arrange
        var numbers = "3;8;4;2;7";

        // Act
        var result = Calculator.SumNumbers(numbers, ';');

        // Assert
        Assert.Equal(24, result);
    }

    // игнорирование нечисловых символов при вычислении суммы
    [Fact]
    public void SumNumbers_IgnoresNonNumericCharacters()
    {
        // Arrange
        var numbers = "3,8,4,a,7";

        // Act
        var result = Calculator.SumNumbers(numbers);

        // Assert
        Assert.Equal(22, result);
    }
}

