using Metrology.Data.DTOs;
using Npgsql;

namespace Metrology.Data.Repositories;

public class PositionsRepository(NpgsqlDataSource dataSource)
{
    public async Task<List<PositionDto>> GetAllPositions(CancellationToken cancellationToken = default)
    {
        await using var connection = await dataSource.OpenConnectionAsync(cancellationToken);
        
        try
        {
            await using var command = new NpgsqlCommand(
                "SELECT * FROM get_all_positions();", connection);
            
            await using var reader = await command.ExecuteReaderAsync(cancellationToken);

            var positions = new List<PositionDto>();
            while (await reader.ReadAsync(cancellationToken))
            {
                positions.Add(MapPositionsFromReader(reader));
            }

            return positions;
        }
        catch (NpgsqlException ex)
        {
            throw new ApplicationException("Database error while fetching employees", ex);
        }
    }
    
    private static PositionDto MapPositionsFromReader(NpgsqlDataReader reader)
    {
        return new PositionDto
        {
            Id = reader.GetInt32(reader.GetOrdinal("id")),
            Title = reader.GetString(reader.GetOrdinal("title"))
        };
    }
}