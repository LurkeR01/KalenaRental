using KalenaRental.Domain.Entities;

namespace KalenaRental.Application.Interfaces;

public interface ICarRepository
{
    Task<IReadOnlyCollection<Car>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Car?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task AddAsync(Car car, CancellationToken cancellationToken = default);
    Task UpdateAsync(Car car, CancellationToken cancellationToken = default);
    Task DeleteAsync(Car car, CancellationToken cancellationToken = default);
}