namespace PCB.Manufacturing.Model;

public class ValidatedQuantity
{
    public enum QuantityValidationResult
    {
        Valid,
        InvalidNegative,
        InvalidNumber
    }

    public static readonly Dictionary<QuantityValidationResult, string> ValidationMessages =
        new()
        {
            { QuantityValidationResult.Valid, "OK" },
            { QuantityValidationResult.InvalidNegative, "Quantity should be positive" },
            { QuantityValidationResult.InvalidNumber, "Quantity should be integer number" }
        };

    public QuantityValidationResult Check(string quantity)
    {
        if (string.IsNullOrEmpty(quantity))
        {
            return QuantityValidationResult.InvalidNumber;
        }

        if (!int.TryParse(quantity, out var integerValue))
        {
            return QuantityValidationResult.InvalidNumber;
        }

        if (integerValue < 0)
        {
            return QuantityValidationResult.InvalidNegative;
        }

        return QuantityValidationResult.Valid;
    }
}