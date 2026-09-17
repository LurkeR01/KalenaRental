using KalenaRental.Application.Dtos;
using KalenaRental.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KalenaRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class CarsController(ICarService carService) : ControllerBase
{
    private readonly ICarService _carService = carService;

    [HttpGet]
    public Task<IReadOnlyCollection<CarDto>> GetAll(CancellationToken cancellationToken)
    {
        // TODO: Return all cars from the service.
        throw new NotImplementedException();
    }

    [HttpGet("{id:int}")]
    public Task<CarDto?> GetById(int id, CancellationToken cancellationToken)
    {
        // TODO: Return the requested car from the service.
        throw new NotImplementedException();
    }

    [HttpPost]
    public Task<CarDto> Create(CreateCarDto dto, CancellationToken cancellationToken)
    {
        // TODO: Create a car through the service.
        throw new NotImplementedException();
    }

    [HttpPut("{id:int}")]
    public Task<CarDto?> Update(int id, UpdateCarDto dto, CancellationToken cancellationToken)
    {
        // TODO: Update a car through the service.
        throw new NotImplementedException();
    }

    [HttpDelete("{id:int}")]
    public Task<bool> Delete(int id, CancellationToken cancellationToken)
    {
        // TODO: Delete a car through the service.
        throw new NotImplementedException();
    }
}