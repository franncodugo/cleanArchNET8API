using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public partial record PhoneNumber
{
    private const int DefaultLenght = 10;
    private const string Pattern = @"/^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$/";

    private PhoneNumber(string value) => Value = value;

    public static PhoneNumber? Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLenght)
            return null;

        return new PhoneNumber(value);
    }

    public string Value { get; init; }

    [GeneratedRegex(Pattern)]
    private static partial Regex PhoneNumberRegex();
}
