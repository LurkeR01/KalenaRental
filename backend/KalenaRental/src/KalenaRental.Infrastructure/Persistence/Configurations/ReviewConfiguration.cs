using KalenaRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalenaRental.Infrastructure.Persistence.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.CarId)
            .IsRequired();

        builder.Property(r => r.CreatedAt)
            .IsRequired();

        builder.Property(r => r.ClientsName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(r => r.ClientsPhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(r => r.Comment)
            .HasMaxLength(1000);
    }
}
