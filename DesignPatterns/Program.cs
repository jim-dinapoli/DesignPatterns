using DesignPatterns.Chapters.Proxies.ExtensionMethods;
using DesignPatterns.Classes;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(
                "Jim",
                null,
                "D.",
                null,
                10000,
                1000.123452324f,
                new Address
                {
                    StreetAddress1 = "1231 Michigan Avenue",
                    StreetAddress2 = "",
                    City = "Lloyd",
                    State = "NJ",
                    ZipCode = "08736"
                });

            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.GetFormattedAddress());

            Console.WriteLine(employee.DeductionPercentage());

            // huh...
            Console.WriteLine(2.Percent() + 3.Percent());
        }
    }
}
