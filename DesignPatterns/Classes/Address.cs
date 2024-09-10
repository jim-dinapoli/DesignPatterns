using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class Address : IAddress
    {
        public Address()
        {
        }

        public Address(
            string streetAddress1,
            string? streetAddress2,
            string city,
            string state,
            string zipCode)
        {
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public required string StreetAddress1 { get; set; }

        public string? StreetAddress2 { get; set; }

        public required string City { get; set; }

        public required string State { get; set; }

        public required string ZipCode { get; set; }

        public string GetFormattedAddress()
        {
            return $"{StreetAddress1},{StreetAddress2 ?? string.Empty}, {City}, {State} {ZipCode}";
        }
    }
}
