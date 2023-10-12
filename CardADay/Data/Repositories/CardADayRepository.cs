using System.Collections.Generic;
using System.Threading.Tasks;
using CardADay.Data.Connections;
using CardADay.Models;
using Dapper;

namespace CardADay.Data.Repositories;

public class CardADayRepository : IRepository<Card>
{
    private readonly IConnection _cardADayConnection;

    public CardADayRepository(IConnection cardADayConnection)
    {
        _cardADayConnection = cardADayConnection;
    }

    public Task<Card> GetByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<IEnumerable<Card>> GetAllAsync()
    {
        var connection = _cardADayConnection.GetSqlConnection();
        return await connection.QueryAsync<Card>(GetSql());
        
        string GetSql()
        {
            return "SELECT * FROM [Cards}";
        }
    }

    public async Task<int> AddAsync(Card entity)
    {
        var connection = _cardADayConnection.GetSqlConnection();
        return await connection.ExecuteAsync(GetSql(), new
        {
            id = entity.Id,
            name = entity.Name,
            manaCost = entity.ManaCost,
            imageUri = entity.ImageUri,
            type = entity.Type,
            ability = entity.Ability,
            flavorText = entity.FlavorText,
            power = entity.Power,
            toughness = entity.Toughness,
            artist = entity.Artist,
            setName = entity.SetName,
            shortSetName = entity.ShortSetName
        });

        string GetSql()
        {
            return @"INSERT INTO [Cards]
                     VALUES (
                         @id,
                         @name,
                         @manaCost
                         @imageUri,
                         @type,
                         @ability,
                         @flavorText,
                         @power,
                         @toughness,
                         @artist,
                         @setName,
                         @shortSetName
                     )";
        }
    }

    public Task<int> UpdateAsync(Card entity)
    {
        throw new System.NotImplementedException();
    }

    public Task<int> DeleteAsync(Card entity)
    {
        throw new System.NotImplementedException();
    }
}