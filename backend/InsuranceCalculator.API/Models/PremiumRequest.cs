
namespace InsuranceCalculator.API.Models;

public class PremiumRequest
{
    public string Name { get; set; } = "";
    public int AgeNextBirthday { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string OccupationName { get; set; } = "";
    public decimal DeathSumInsured { get; set; }
}
