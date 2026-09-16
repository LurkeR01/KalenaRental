using KalenaRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalenaRental.Infrastructure.Persistence.Configurations;

public class CarImageConfiguration : IEntityTypeConfiguration<CarImage>
{
    public void Configure(EntityTypeBuilder<CarImage> builder)
    {
        builder.ToTable("CarImages");

        builder.HasKey(ci => ci.Id);

        builder.Property(ci => ci.CarId)
            .IsRequired();

        builder.Property(ci => ci.Url)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(ci => ci.PublicId)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(ci => ci.SortOrder)
            .IsRequired();

        builder.HasIndex(ci => new { ci.CarId, ci.SortOrder })
            .IsUnique();
    }
}
