namespace PCB.Manufacturing.Model;

public class ValidatedZipcode
{
    public enum ZipcodeValidationResult
    {
        Valid,
        InvalidLength,
        InvalidChars
    }

    public static readonly Dictionary<ZipcodeValidationResult, string> ValidationMessages =
        new()
        {
            { ZipcodeValidationResult.Valid, "OK" },
            { ZipcodeValidationResult.InvalidLength, "Zipcode should contain 6 digits" },
            { ZipcodeValidationResult.InvalidChars, "Zipcode should contain only digits" }
        };


    public ZipcodeValidationResult Check(string zip)
    {
        if (zip.Length != 6)
        {
            return ZipcodeValidationResult.InvalidLength;
        }

        if (zip.Any(_ => !char.IsDigit(_)))
        {
            return ZipcodeValidationResult.InvalidChars;
        }

        return ZipcodeValidationResult.Valid;
    }
}