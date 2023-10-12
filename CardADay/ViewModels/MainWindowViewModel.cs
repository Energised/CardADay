using System.Threading.Tasks;
using CardADay.Data.Repositories;
using CardADay.Features.UpdateCardDb;
using CardADay.Models;

namespace CardADay.ViewModels;

public class MainWindowViewModel
{
    private readonly IRepository<Card> _cardADayRepository;
    
    private Card LoadedCard { get; set; } 

    public MainWindowViewModel(IRepository<Card> cardADayRepository)
    {
        _cardADayRepository = cardADayRepository;
    }

    public async Task GetAllCardsTest()
    {
        // var getCardList = new GetCardList(_cardADayRepository);
        // await getCardList.GetAllCards();
    }
}