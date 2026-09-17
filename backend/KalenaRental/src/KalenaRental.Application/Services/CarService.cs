using KalenaRental.Application.Dtos;
using KalenaRental.Application.Interfaces;

namespace KalenaRental.Application.Services;

public sealed class CarService(ICarRepository carRepository) : ICarService
{
    private readonly ICarRepository _carRepository = carRepository;

    public Task<IReadOnlyCollection<CarDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // TODO: Implement car list retrieval and entity-to-DTO mapping.
        throw new NotImplementedException();
    }

    public Task<CarDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        // TODO: Implement car retrieval by id and entity-to-DTO mapping.
        throw new NotImplementedException();
    }

    public Task<CarDto> CreateAsync(CreateCarDto dto, CancellationToken cancellationToken = default)
    {
        // TODO: Create a Car, persist it through the repository, and return its DTO.
        throw new NotImplementedException();
    }

    public Task<CarDto?> UpdateAsync(int id, UpdateCarDto dto, CancellationToken cancellationToken = default)
    {
        // TODO: Load the Car, update it, persist it, and return its DTO.
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default)
    {
        // TODO: Load and delete the Car through the repository.
        throw new NotImplementedException();
    }
}