using DesignPatterns.Chapters.Proxies;
using DesignPatterns.Chapters.Proxies.ExtensionMethods;

namespace DesignPatterns.Classes;

public class Employee(
    string firstName,
    string? middleName,
    string lastName,
    string? suffix,
    float salary,
    float? totalWeeklyDeduction,
    Address? address)
        : Person(firstName, middleName, lastName, suffix, address)
{
    public float Salary { get; set; } = salary;
    public float? TotalWeeklyDeduction { get; set; } = totalWeeklyDeduction;

    public override string ToString()
    {
        return $"{base.ToString()}, {Salary}, {TotalWeeklyDeduction}";
    }

    public Percentage DeductionPercentage()
    {
        var percentage =  ((TotalWeeklyDeduction / Salary) * 100);
        return percentage?.Percent() ?? default;
    }
}