
namespace TSInsurance.Models;

public class Claim
{
    public int ClaimId { get; set; }
    public string ClaimNumber { get; set; }
    public DateTime DateOfClaim { get; set; }
    public decimal ClaimAmount { get; set; }
    public string Status { get; set; }

    // Foreign Key
    public int PolicyId { get; set; }

    // Navigation Property
    public Policy Policy { get; set; }
}
