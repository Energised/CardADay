using System.Data;

namespace CardADay.Data.Connections;

public interface IConnection
{
    public IDbConnection GetSqlConnection();
}