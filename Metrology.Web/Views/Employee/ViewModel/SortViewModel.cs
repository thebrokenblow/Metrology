namespace Metrology.Web.Views.Employee.ViewModel;

public class SortViewModel(SortState sortOrder)
{
    public SortState NameSort { get; private set; } = sortOrder == SortState.FirstNameAsc ? SortState.FirstNameDesc : SortState.FirstNameAsc;
    public SortState LastNameSort { get; private set; } = sortOrder == SortState.LastNameAsc ? SortState.LastNameDesc : SortState.LastNameAsc;
    public SortState MiddleNameSort { get; private set; } = sortOrder == SortState.MiddleNameAsc ? SortState.MiddleNameDesc : SortState.MiddleNameAsc;
    public SortState DepartmentNameSort { get; private set; } = sortOrder == SortState.DepartmentNameAsc ? SortState.DepartmentNameDesc : SortState.DepartmentNameAsc;
    public SortState PositionTitleSort { get; private set; } = sortOrder == SortState.PositionTitleAsc ? SortState.PositionTitleDesc : SortState.PositionTitleAsc;
}