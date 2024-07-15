namespace SonAdvert.Frontend.Models;

public class ClientSummary
{
    public Guid Id { get; set; }

    public Guid ClientTypeId { get; set; }

    public required string Name { get; set; }

    public required string Address1 { get; set; }

    public required string Address2 { get; set; }

    public required string City { get; set; }

    public required string State { get; set; }

    public required string Zip { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime DeletedDate { get; set; }

    public bool IsActive { get; set; }
}
