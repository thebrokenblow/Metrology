using Metrology.Data.DTOs;
using Metrology.Data.Repositories;
using Metrology.Web.ViewModel;
using Metrology.Web.Views.Employee.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Metrology.Web.Controllers;

public class EmployeeController(
    EmployeeRepository employeeRepository, 
    DepartmentRepository departmentRepository,
    PositionsRepository positionsRepository) : Controller
{
    private const int PageSize = 15;

    public async Task<IActionResult> Index(
        SortState sortOrder,
        int page = 1,
        int? departmentId = null, 
        int? positionId = null, 
        string? searchString = null)
    {
        var (employees, filteredCount) = await employeeRepository.GetEmployeesPaginatedAsync(
            (page - 1) * PageSize, 
            PageSize, 
            searchString,
            departmentId,
            positionId);
        
        employees = SortEmployees(sortOrder, employees);
        
        var indexViewModel = new IndexViewModel
        {
            Departments = new SelectList(await departmentRepository.GetAllAsync(), "Id", "Name", departmentId),
            Positions = new SelectList(await positionsRepository.GetAllPositions(), "Id", "Title", positionId),
            Employees = employees,
            SortViewModel = new SortViewModel(sortOrder),
            PageViewModel = new PageViewModel(filteredCount, page, PageSize),
            SearchString = searchString,
            SelectedDepartment = departmentId,
            SelectedPosition = positionId
        };
            
        return View(indexViewModel);
    }
    
    private static List<EmployeeDto> SortEmployees(SortState sortOrder, List<EmployeeDto> employees) => sortOrder switch
    {
        SortState.FirstNameAsc => employees.OrderBy(employee => employee.FirstName).ToList(),
        SortState.FirstNameDesc => employees.OrderByDescending(employee => employee.FirstName).ToList(),
        SortState.LastNameAsc => employees.OrderBy(employee => employee.LastName).ToList(),
        SortState.LastNameDesc => employees.OrderByDescending(employee => employee.LastName).ToList(),
        SortState.MiddleNameAsc => employees.OrderBy(employee => employee.MiddleName).ToList(),
        SortState.MiddleNameDesc => employees.OrderByDescending(employee => employee.MiddleName).ToList(),
        SortState.DepartmentNameAsc => employees.OrderBy(employee => employee.DepartmentName).ToList(),
        SortState.DepartmentNameDesc => employees.OrderByDescending(employee => employee.DepartmentName).ToList(),
        SortState.PositionTitleAsc => employees.OrderBy(employee => employee.PositionTitle).ToList(),
        SortState.PositionTitleDesc => employees.OrderByDescending(employee => employee.PositionTitle).ToList(),
        _ => employees
    };
}