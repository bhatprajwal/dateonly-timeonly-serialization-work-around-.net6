namespace dateonly_timeonly_serialization_work_around_.net6.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public TimeOnly TimeOfBirth { get; set; }
    public string? BirthPlace { get; set; }
}