namespace DesignPatterns.Interfaces;

public interface IPerson : IContactInfo
{
    string FirstName { get; set; }
    string? MiddleName { get; set; }
    string LastName { get; set; }
    string? Suffix { get; set; }
    IAddress? Address { get; set; }
}