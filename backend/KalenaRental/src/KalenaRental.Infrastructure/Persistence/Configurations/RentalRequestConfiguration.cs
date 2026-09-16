using KalenaRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalenaRental.Infrastructure.Persistence.Configurations;

public class RentalRequestConfiguration : IEntityTypeConfiguration<RentalRequest>
{
    public void Configure(EntityTypeBuilder<RentalRequest> builder)
    {
        builder.ToTable("RentalRequests");

        builder.HasKey(rr => rr.Id);

        builder.Property(rr => rr.CarId)
            .IsRequired();

        builder.Property(rr => rr.CreatedAt)
            .IsRequired();

        builder.Property(rr => rr.ClientsName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(rr => rr.ClientsPhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(rr => rr.Comment)
            .HasMaxLength(1000);
    }
}
