using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CardADay.Data.Connections;

public class CardADayConnection : IConnection
{
    private readonly IConfiguration _configuration;

    public CardADayConnection(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public IDbConnection GetSqlConnection()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        return new SqlConnection(connectionString);
    }
}