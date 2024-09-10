using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes;

public class Person(
    string firstName,
    string? middleName,
    string lastName,
    string? suffix,
    Address? address)
        : IPerson
{
    public string FirstName { get; set; } = firstName;
    public string? MiddleName { get; set; } = middleName;
    public string LastName { get; set; } = lastName;
    public string? Suffix { get; set; } = suffix;
    public IAddress? Address { get; set; } = address;

    public string GetFullName()
    {
        return string.IsNullOrEmpty(Suffix)
            ? $"{FirstName} {MiddleName} {LastName}"
            : $"{FirstName} {MiddleName} {LastName}, {Suffix}";
    }

    public string? GetFormattedAddress()
    {
        return Address != null ? Address.GetFormattedAddress() : string.Empty;
    }
}