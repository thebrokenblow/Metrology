using Metrology.Data.DTOs;
using Metrology.Web.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Metrology.Web.Views.Employee.ViewModel;

public class IndexViewModel
{
    public required List<EmployeeDto> Employees { get; init; }
    
    public required PageViewModel PageViewModel { get; init; }
    public required SortViewModel SortViewModel { get; init; } 
    
    public required SelectList Departments { get; init; }
    public required SelectList Positions { get; init; }
    
    public string? SearchString { get; init; }
    public int? SelectedPosition { get; init; }
    public int? SelectedDepartment { get; init; }
}