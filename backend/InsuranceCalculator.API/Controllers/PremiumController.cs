
using Microsoft.AspNetCore.Mvc;
using InsuranceCalculator.API.Models;

namespace InsuranceCalculator.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PremiumController : ControllerBase
{
    [HttpPost("calculate")]
    public IActionResult Calculate(PremiumRequest req)
    {
        if (req.AgeNextBirthday <= 0 || req.DeathSumInsured <= 0)
            return BadRequest("Invalid age or sum insured");

        var factor = OccupationFactor.GetFactor(req.OccupationName);

        decimal premium = (req.DeathSumInsured * factor * req.AgeNextBirthday) / (1000m * 12m);
        premium = Math.Round(premium, 2);

        return Ok(new PremiumResponse
        {
            Name = req.Name,
            MonthlyPremium = premium
        });
    }
}
