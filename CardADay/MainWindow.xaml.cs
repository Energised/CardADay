using System.Windows;
using CardADay.Data.Repositories;
using CardADay.Models;

namespace CardADay;

public partial class MainWindow : Window
{
    private readonly IRepository<Card> _cardADayRepository;
    
    private Card LoadedCard { get; set; }

    public MainWindow(IRepository<Card> cardADayRepository)
    {
        InitializeComponent();
        _cardADayRepository = cardADayRepository;
    }

    private async void GetACard(object sender, RoutedEventArgs eventArgs)
    {
        var data = await _cardADayRepository.GetAllAsync();
    }

    private void ReloadMtgDatabase(object sender, RoutedEventArgs eventArgs)
    {
        
    }
}