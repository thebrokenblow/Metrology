namespace Metrology.Web.ViewModel;

public class PageViewModel(int countAllElements, int pageNumber, int pageSize)
{
    public int PageNumber { get; } = pageNumber;
    public int TotalPages { get; } = (int)Math.Ceiling(countAllElements / (double)pageSize);
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
}