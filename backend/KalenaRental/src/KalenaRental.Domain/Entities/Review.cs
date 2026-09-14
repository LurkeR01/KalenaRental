namespace KalenaRental.Domain.Entities;

public class Review
{
    private Review()
    {
    }

    private Review(int carId, DateTime createdAt, string clientsName, string clientsPhoneNumber, string? comment)
    {
        if (createdAt > DateTime.UtcNow)
            throw new ArgumentException("CreatedAt cannot be in the future.", nameof(createdAt));
        Validate(clientsName, clientsPhoneNumber);

        CarId = carId;
        CreatedAt = createdAt;
        ClientsName = clientsName;
        ClientsPhoneNumber = clientsPhoneNumber;
        Comment = comment;
    }

    public int Id { get; private set; }
    public int CarId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string ClientsName { get; private set; } = null!;
    public string ClientsPhoneNumber { get; private set; } = null!;
    public string? Comment { get; private set; }

    public static Review Create(int carId, string clientsName, string clientsPhoneNumber, string? comment = null)
    {
        return new Review(carId, DateTime.UtcNow, clientsName, clientsPhoneNumber, comment);
    }

    private static void Validate(string clientsName, string clientsPhoneNumber)
    {
        if (string.IsNullOrWhiteSpace(clientsName))
            throw new ArgumentException("Clients name cannot be empty.", nameof(clientsName));
        if (string.IsNullOrWhiteSpace(clientsPhoneNumber))
            throw new ArgumentException("Clients phone number cannot be empty.", nameof(clientsPhoneNumber));
    }
}