using KalenaRental.Application.Interfaces;
using KalenaRental.Domain.Entities;
using KalenaRental.Infrastructure.Persistence;

namespace KalenaRental.Infrastructure.Repositories;

public sealed class CarRepository(AppDbContext dbContext) : ICarRepository
{
    private readonly AppDbContext _dbContext = dbContext;

    public Task<IReadOnlyCollection<Car>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // TODO: Read all cars from dbContext.Cars.
        throw new NotImplementedException();
    }

    public Task<Car?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        // TODO: Read a car by id from dbContext.Cars.
        throw new NotImplementedException();
    }

    public Task AddAsync(Car car, CancellationToken cancellationToken = default)
    {
        // TODO: Add the car and save changes through dbContext.
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Car car, CancellationToken cancellationToken = default)
    {
        // TODO: Update the car and save changes through dbContext.
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Car car, CancellationToken cancellationToken = default)
    {
        // TODO: Delete the car and save changes through dbContext.
        throw new NotImplementedException();
    }
}