namespace DesignPatterns.Interfaces
{
    public interface IAddress
    {
        string StreetAddress1 { get; set; }
        string? StreetAddress2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string? GetFormattedAddress();
    }
}