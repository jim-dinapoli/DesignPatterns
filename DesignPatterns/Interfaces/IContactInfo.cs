namespace DesignPatterns.Interfaces;

public interface IContactInfo
{
    public string GetFullName();
    public string? GetFormattedAddress();
}