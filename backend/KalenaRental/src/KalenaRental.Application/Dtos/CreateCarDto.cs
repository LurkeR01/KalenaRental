using KalenaRental.Domain.Enums;

namespace KalenaRental.Application.Dtos;

public sealed record CreateCarDto(
    string Name,
    decimal PricePerDay,
    CarClass Class,
    BodyType BodyType,
    decimal EngineCapacity,
    Transmission Transmission,
    FuelType FuelType,
    string Description,
    ActivityStatus ActivityStatus);