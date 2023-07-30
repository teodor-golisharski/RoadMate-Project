namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Payment;

    public class PaymentEntityConfigurations : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
               .Property(p => p.PaymentMethod)
               .HasConversion<string>();
        }
    }
}
