using System.IO;
using System.Windows;
using CardADay.Data.Connections;
using CardADay.Data.Repositories;
using CardADay.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CardADay;

public partial class App : Application
{
    public static IHost AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>();
                services.AddTransient<IConnection, CardADayConnection>();
                services.AddTransient<IRepository<Card>, CardADayRepository>();
            })
            .ConfigureAppConfiguration((configContext, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .AddEnvironmentVariables()
                    .Build();
            })
            .Build();
    }

    protected override async void OnStartup(StartupEventArgs startupEventArgs)
    {
        await AppHost.StartAsync();

        var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
        startupForm.Show();
        
        base.OnStartup(startupEventArgs);
    }

    protected override async void OnExit(ExitEventArgs exitEventArgs)
    {
        await AppHost.StopAsync();
        base.OnExit(exitEventArgs);
    }
}