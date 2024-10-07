using Microsoft.AspNetCore.Mvc;
using TSInsurance.Data;

namespace TSInsurance.Services;
public class PolicyService
{
    private readonly ApplicationDbContext _context;

    public PolicyService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<decimal> CalculatePremium(int policyId)
    {
        var policy = await _context.Policies.FindAsync(policyId);
        if (policy == null)
        {
            throw new Exception("Policy not found");
        }

        // Implement custom premium calculation logic
        decimal premium = policy.PremiumAmount;
        return premium;
    }
}
