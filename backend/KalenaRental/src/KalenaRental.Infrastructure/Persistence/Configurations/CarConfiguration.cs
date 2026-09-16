using KalenaRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KalenaRental.Infrastructure.Persistence.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(c => c.PricePerDay)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(c => c.Class)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.BodyType)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.EngineCapacity)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(c => c.Transmission)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.FuelType)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.Description)
            .IsRequired();

        builder.Property(c => c.ActivityStatus)
            .HasConversion<string>()
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .IsRequired();

        builder.Property(c => c.UpdatedAt)
            .IsRequired();

        builder.HasMany(c => c.CarImages)
            .WithOne()
            .HasForeignKey(ci => ci.CarId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
