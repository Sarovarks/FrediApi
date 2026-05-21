namespace FrediApi;

public class ShipmentValidator
{
    public bool IsWeightValid(double weightInKg)
    {
        return weightInKg > 0 && weightInKg <= 1000;
    }

    public string GetShipmentCategory(double weightInKg)
    {
        if (weightInKg <= 0)
            return "Invalid";
        if (weightInKg < 5)
            return "Small";
        if (weightInKg < 50)
            return "Medium";
        return "Large";
    }
}