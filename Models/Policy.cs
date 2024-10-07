
namespace TSInsurance.Models;
public class Policy
{
    public int PolicyId { get; set; }
    public string PolicyNumber { get; set; }
    public decimal PremiumAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string PolicyType { get; set; }

    // Foreign Key
    public int CustomerId { get; set; }

    // Navigation Properties
    public Customer Customer { get; set; }
    public ICollection<Claim> Claims { get; set; }
}
