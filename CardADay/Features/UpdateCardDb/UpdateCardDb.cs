using System;
using System.Threading.Tasks;
using CardADay.Data.Repositories;
using CardADay.Models;

namespace CardADay.Features.UpdateCardDb;

public class UpdateCardDb
{
    private readonly IRepository<Card> _cardADayRepository;

    public UpdateCardDb(IRepository<Card> cardADayRepository)
    {
        _cardADayRepository = cardADayRepository;
    }

    public async Task GetAllCards()
    {
        // TODO
    }
}