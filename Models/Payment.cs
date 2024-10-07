
namespace TSInsurance.Models;

public class Payment
{
    public int PaymentId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }

    // Foreign Key
    public int PolicyId { get; set; }

    // Navigation Property
    public Policy Policy { get; set; }
}
