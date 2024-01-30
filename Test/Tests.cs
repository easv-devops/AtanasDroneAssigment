using System;
using Xunit;

public class PTests
{
    [Fact]
    public void Multiply_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = Program.Multiply(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Devide_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        int result = Program.Devide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Devide_DivideByZero_ThrowsException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => Program.Devide(a, b));
    }
}