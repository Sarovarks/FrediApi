using FrediApi;
using Xunit;

namespace FrediApi.Tests;

public class ShipmentValidatorTests
{
    [Fact]
    public void IsWeightValid_PositiveWeight_ReturnsTrue()
    {
        var validator = new ShipmentValidator();
        bool result = validator.IsWeightValid(50);
        Assert.True(result);
    }

    [Fact]
    public void IsWeightValid_ZeroWeight_ReturnsFalse()
    {
        var validator = new ShipmentValidator();
        bool result = validator.IsWeightValid(0);
        Assert.False(result);
    }

    [Fact]
    public void IsWeightValid_TooHeavy_ReturnsFalse()
    {
        var validator = new ShipmentValidator();
        bool result = validator.IsWeightValid(1500);
        Assert.False(result);
    }

    [Fact]
    public void GetShipmentCategory_SmallWeight_ReturnsSmall()
    {
        var validator = new ShipmentValidator();
        string category = validator.GetShipmentCategory(2);
        Assert.Equal("Small", category);
    }

    [Fact]
    public void GetShipmentCategory_LargeWeight_ReturnsLarge()
    {
        var validator = new ShipmentValidator();
        string category = validator.GetShipmentCategory(500);
        Assert.Equal("Large", category);
    }
}