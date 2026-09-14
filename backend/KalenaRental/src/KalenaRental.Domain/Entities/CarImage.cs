namespace KalenaRental.Domain.Entities;

public class CarImage
{
    private CarImage(int carId, string url, string publicId, int sortOrder)
    {
        Update(carId, url, publicId, sortOrder);
    }

    private CarImage()
    {
    }

    public int Id { get; private set; }
    public int CarId { get; private set; }
    public string Url { get; private set; } = null!;
    public string PublicId { get; private set; } = null!;
    public int SortOrder { get; private set; }

    public static CarImage Create(int carId, string url, string publicId, int sortOrder)
    {
        return new CarImage(carId, url, publicId, sortOrder);
    }

    public void Update(int carId, string url, string publicId, int sortOrder)
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new ArgumentException("Url cannot be empty.", nameof(url));
        if (publicId is null)
            throw new ArgumentNullException(nameof(publicId));
        if (sortOrder < 0)
            throw new ArgumentOutOfRangeException(nameof(sortOrder), "Sort order cannot be negative.");

        CarId = carId;
        Url = url;
        PublicId = publicId;
        SortOrder = sortOrder;
    }
}