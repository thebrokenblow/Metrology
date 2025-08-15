using Metrology.Data.Repositories;
using Metrology.Web.ViewModel;
using Metrology.Web.Views.Employee.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Metrology.Web.Controllers;

public class EmployeeController(
    EmployeeRepository employeeRepository, 
    DepartmentRepository departmentRepository,
    PositionsRepository positionsRepository) : Controller
{
    private int pageSize = 10;
    public async Task<IActionResult> Index(
        int? departmentId = null, 
        int? positionId = null, 
        string? searchQuery = null)
    {
        var indexViewModel = new IndexViewModel
        {
            Departments = await departmentRepository.GetAllAsync(),
            Positions = await positionsRepository.GetAllPositions(),
            Employees = await employeeRepository.GetEmployeesPaginatedAsync((1 - 1) * pageSize, pageSize),
            PageViewModel = new PageViewModel(0, 0, 0)
        };
            
        return View(indexViewModel);
    }

    public IActionResult Create()
    {
        return View();
    }
}