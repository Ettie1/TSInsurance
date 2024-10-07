using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TSInsurance.Models;

namespace TSInsurance.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Claim> Claims { get; set; }
    public DbSet<Payment> Payments{ get; set; }
    public DbSet<Policy> Policies{ get; set; }
}
