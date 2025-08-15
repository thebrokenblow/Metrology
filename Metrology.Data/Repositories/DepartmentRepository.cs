using Metrology.Data.DTOs;
using Npgsql;

namespace Metrology.Data.Repositories;

public class DepartmentRepository(NpgsqlDataSource dataSource)
{
    public async Task<List<DepartmentDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        await using var connection = await dataSource.OpenConnectionAsync(cancellationToken);
        
        try
        {
            await using var command = new NpgsqlCommand(
                "SELECT * FROM get_all_departments();", connection);
            
            await using var reader = await command.ExecuteReaderAsync(cancellationToken);

            var departmentDto = new List<DepartmentDto>();
            while (await reader.ReadAsync(cancellationToken))
            {
                departmentDto.Add(MapDepartmentsFromReader(reader));
            }

            return departmentDto;
        }
        catch (NpgsqlException ex)
        {
            throw new ApplicationException("Database error while fetching department", ex);
        }
    }
    
    private static DepartmentDto MapDepartmentsFromReader(NpgsqlDataReader reader)
    {
        return new DepartmentDto
        {
            Id = reader.GetInt32(reader.GetOrdinal("id")),
            Name = reader.GetString(reader.GetOrdinal("name"))
        };
    }
}