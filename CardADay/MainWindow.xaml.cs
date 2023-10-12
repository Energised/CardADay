using System.Windows;
using CardADay.ViewModels;

namespace CardADay;

public partial class MainWindow : Window
{
    private MainWindowViewModel ViewModel => (MainWindowViewModel) DataContext;
    
    public MainWindow() => InitializeComponent();

    private async void CallMtgTest(object sender, RoutedEventArgs e)
    {
        await ViewModel.GetAllCardsTest();
    }
}