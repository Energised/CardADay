using Autofac;
using System;
using System.Windows;
using CardADay.Data.Connections;
using CardADay.Data.Repositories;
using CardADay.Models;
using CardADay.ViewModels;

namespace CardADay;

public partial class App : Application
{
    private IContainer _container { get; set; }

    protected override void OnStartup(StartupEventArgs startupEventArgs)
    {
        base.OnStartup(startupEventArgs);
        _container = BuildContainer();
        _container.Resolve<MainWindowViewModel>();
        DISource.Resolver = Resolve;
        //ResolveViewModels();
    }
    
    object Resolve(Type type, object key, string name) {
        if(type == null)
            return null;
        if(key != null)
            return _container.ResolveKeyed(key, type);
        if(name != null)
            return _container.ResolveNamed(name, type);
        return _container.Resolve(type);
    }

    private static IContainer BuildContainer()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<IConnection>().As<CardADayConnection>();
        builder.RegisterType<IRepository<Card>>().As<CardADayRepository>();
        builder.RegisterType<MainWindowViewModel>();
        var container = builder.Build();
        return container;
    }
}