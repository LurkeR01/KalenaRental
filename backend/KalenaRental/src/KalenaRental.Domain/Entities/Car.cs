using KalenaRental.Domain.Enums;

namespace KalenaRental.Domain.Entities;

public class Car
{
    private readonly List<CarImage> _carImages = [];

    private Car()
    {
    }

    private Car(
        string name,
        decimal pricePerDay,
        CarClass carClass,
        BodyType bodyType,
        decimal engineCapacity,
        Transmission transmission,
        FuelType fuelType,
        string description,
        ActivityStatus activityStatus,
        DateTime createdAt)
    {
        Validate(name, pricePerDay, description);
        if (createdAt > DateTime.UtcNow)
            throw new ArgumentException("CreatedAt cannot be in the future.", nameof(createdAt));

        Name = name;
        PricePerDay = pricePerDay;
        Class = carClass;
        BodyType = bodyType;
        EngineCapacity = engineCapacity;
        Transmission = transmission;
        FuelType = fuelType;
        Description = description;
        ActivityStatus = activityStatus;
        CreatedAt = createdAt;
        UpdatedAt = createdAt;
    }

    public int Id { get; private set; }
    public string Name { get; private set; } = null!;
    public decimal PricePerDay { get; private set; }
    public CarClass Class { get; private set; }
    public BodyType BodyType { get; private set; }
    public decimal EngineCapacity { get; private set; }
    public Transmission Transmission { get; private set; }
    public FuelType FuelType { get; private set; }
    public string Description { get; private set; } = null!;
    public ActivityStatus ActivityStatus { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public IReadOnlyCollection<CarImage> CarImages { get; private set; } = [];

    public static Car Create(
        string name,
        decimal pricePerDay,
        CarClass carClass,
        BodyType bodyType,
        decimal engineCapacity,
        Transmission transmission,
        FuelType fuelType,
        string description,
        ActivityStatus activityStatus)
    {
        return new Car(name, pricePerDay, carClass, bodyType, engineCapacity, transmission, fuelType, description, activityStatus, DateTime.UtcNow);
    }

    public void Update(
        string name,
        decimal pricePerDay,
        CarClass carClass,
        BodyType bodyType,
        decimal engineCapacity,
        Transmission transmission,
        FuelType fuelType,
        string description,
        ActivityStatus activityStatus)
    {
        Validate(name, pricePerDay, description);

        Name = name;
        PricePerDay = pricePerDay;
        Class = carClass;
        BodyType = bodyType;
        EngineCapacity = engineCapacity;
        Transmission = transmission;
        FuelType = fuelType;
        Description = description;
        ActivityStatus = activityStatus;
        UpdatedAt = DateTime.UtcNow;
    }

    public void AddImage(CarImage image)
    {
        ArgumentNullException.ThrowIfNull(image);
        _carImages.Add(image);
        CarImages = _carImages.AsReadOnly();
    }

    private static void Validate(string name, decimal pricePerDay, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        if (pricePerDay <= 0)
            throw new ArgumentOutOfRangeException(nameof(pricePerDay), "Price per day must be greater than zero.");
        if (description is null)
            throw new ArgumentNullException(nameof(description));
    }
}