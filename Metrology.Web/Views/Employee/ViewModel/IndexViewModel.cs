using Metrology.Data.DTOs;
using Metrology.Web.ViewModel;

namespace Metrology.Web.Views.Employee.ViewModel;

public class IndexViewModel
{
    public required List<EmployeeDto> Employees { get; init; }
    public required PageViewModel PageViewModel { get; init; }
    public required List<DepartmentDto> Departments { get; init; }
    public required List<PositionDto> Positions { get; init; }
    public int SelectedPositionIndex { get; set; }
    public string? SearchString { get; set; }
}