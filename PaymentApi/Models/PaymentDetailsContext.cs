using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Models
{
    public class PaymentDetailsContext : DbContext
    {
        public PaymentDetailsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<PaymentDetails> PaymentDetail { get; set; }
    }

}
