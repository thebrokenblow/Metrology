using Metrology.Data.DTOs;
using Npgsql;

namespace Metrology.Data.Repositories;

public class EmployeeRepository(NpgsqlDataSource dataSource)
{
    public async Task<List<EmployeeDto>> GetEmployeesPaginatedAsync(
        int offset = 0,
        int limit = 10,
        CancellationToken cancellationToken = default)
    {
        await using var connection = await dataSource.OpenConnectionAsync(cancellationToken);
        
        try
        {
            await using var command = new NpgsqlCommand(
                "SELECT * FROM get_employees_paginated(@count_skip, @count_take)",
                connection);
            
            command.Parameters.AddWithValue("count_skip", offset);
            command.Parameters.AddWithValue("count_take", limit);
            
            await using var reader = await command.ExecuteReaderAsync(cancellationToken);

            var employees = new List<EmployeeDto>();
            while (await reader.ReadAsync(cancellationToken))
            {
                employees.Add(MapEmployeeFromReader(reader));
            }

            return employees;
        }
        catch (NpgsqlException ex)
        {
            throw new ApplicationException("Database error while fetching employees", ex);
        }
    }

    private static EmployeeDto MapEmployeeFromReader(NpgsqlDataReader reader)
    {
        return new EmployeeDto
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
}