namespace SonAdvert.Frontend.Models;

public class AdvertisementType
{
    public Guid Id { get; set; }

    public required string TypeName { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public DateTime DeletedDate { get; set; }

    public bool IsActive { get; set; }
}

/*
    ***Types***
    Display
    Classified
    Web
*/