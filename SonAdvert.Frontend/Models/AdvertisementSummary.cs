namespace SonAdvert.Frontend.Models;

public class AdvertisementSummary
{
    public Guid Id { get; set; }

    public Guid ClientId { get; set; }

    public Guid AdvertisementTypeId { get; set; }

    public required string AdvertisementName { get; set; }

    public required string AdvertisementDescription { get; set; }

    public float AdvertisementSize { get; set; }

    public decimal AdvertisementCost { get; set; }

    public DateTime StartDate { get; set; }

    public int NumberOfRuns { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime DeletedDate { get; set; }

    public bool IsActive { get; set; }

}
