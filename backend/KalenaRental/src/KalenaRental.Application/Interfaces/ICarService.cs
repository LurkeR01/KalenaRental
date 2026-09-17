using KalenaRental.Application.Dtos;

namespace KalenaRental.Application.Interfaces;

public interface ICarService
{
    Task<IReadOnlyCollection<CarDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<CarDto?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<CarDto> CreateAsync(CreateCarDto dto, CancellationToken cancellationToken = default);
    Task<CarDto?> UpdateAsync(int id, UpdateCarDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
}