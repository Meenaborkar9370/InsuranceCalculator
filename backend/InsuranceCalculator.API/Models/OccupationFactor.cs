
namespace InsuranceCalculator.API.Models;

public static class OccupationFactor
{
    private static readonly Dictionary<string, decimal> _factors =
        new(StringComparer.OrdinalIgnoreCase)
        {
            { "Cleaner", 1.50m },
            { "Doctor", 1.00m },
            { "Author", 1.25m },
            { "Farmer", 1.75m },
            { "Mechanic", 1.75m },
            { "Florist", 1.50m },
            { "Other", 1.50m }
        };

    public static decimal GetFactor(string occupation)
    {
        if (_factors.TryGetValue(occupation ?? "", out var f))
            return f;

        return 1.50m;
    }
}
