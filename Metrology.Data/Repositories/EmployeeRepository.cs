using Metrology.Data.DTOs;
using Npgsql;

namespace Metrology.Data.Repositories;

public class EmployeeRepository(NpgsqlDataSource dataSource)
{
    public async Task<(List<EmployeeDto> Employees, int FilteredCount)> GetEmployeesPaginatedAsync(
        int offset,
        int limit,
        string? searchString = null,
        int? departmentId = null, 
        int? positionId = null, 
        CancellationToken cancellationToken = default)
    {
        await using var connection = await dataSource.OpenConnectionAsync(cancellationToken);
        
        try
        {
            var employees = new List<EmployeeDto>();
            var filteredCount = 0;
            
            var dataCommand = new NpgsqlCommand(
                "SELECT * FROM get_filtered_employees(@position_id, @department_id, @search_string, @offset, @limit)",
                connection);
            
            dataCommand.Parameters.AddWithValue("position_id", positionId ?? (object)DBNull.Value);
            dataCommand.Parameters.AddWithValue("department_id", departmentId ?? (object)DBNull.Value);
            dataCommand.Parameters.AddWithValue("search_string", searchString ?? (object)DBNull.Value);
            dataCommand.Parameters.AddWithValue("offset", offset);
            dataCommand.Parameters.AddWithValue("limit", limit);
            
            await using (var reader = await dataCommand.ExecuteReaderAsync(cancellationToken))
            {
                while (await reader.ReadAsync(cancellationToken))
                {
                    employees.Add(MapEmployeeFromReader(reader));
                    
                    if (filteredCount == 0)
                    {
                        filteredCount = reader.GetInt32(reader.GetOrdinal("total_count"));
                    }
                }
            }

            return (employees, filteredCount);
        }
        catch (NpgsqlException ex)
        {
            throw new ApplicationException("Database error while fetching employees", ex);
        }
    }

    private static EmployeeDto MapEmployeeFromReader(NpgsqlDataReader reader) =>
        new()
        {
            Id = reader.GetInt32(reader.GetOrdinal("id")),
            FirstName = reader.GetString(reader.GetOrdinal("first_name")),
            LastName = reader.GetString(reader.GetOrdinal("last_name")),
            MiddleName = reader.IsDBNull(reader.GetOrdinal("middle_name")) 
                ? null 
                : reader.GetString(reader.GetOrdinal("middle_name")),
            PositionTitle = reader.GetString(reader.GetOrdinal("position_title")),
            DepartmentName = reader.GetString(reader.GetOrdinal("department_name")),
            Email = reader.GetString(reader.GetOrdinal("email")),
            Phone = reader.GetString(reader.GetOrdinal("phone")),
            ResponsibilityStatus = reader.GetString(reader.GetOrdinal("responsibility_status"))
        };
}