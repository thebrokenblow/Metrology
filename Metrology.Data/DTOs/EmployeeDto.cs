namespace Metrology.Data.DTOs;

public class EmployeeDto
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string PositionTitle { get; set; }
    public required string DepartmentName { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string ResponsibilityStatus { get; set; }
}