using CommunityToolkit.Maui;
using ShellUIPoc.Pages;
using ShellUIPoc.ViewModels;

namespace ShellUIPoc;

public static class MauiProgram
{
    public static MauiApp MauiApp { get; private set; }

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        RegisterViewModels(builder.Services);
        RegisterPages(builder.Services);

        MauiApp = builder.Build();
        return MauiApp;
	}

    static void RegisterPages(IServiceCollection services)
    {
        services.AddTransient<AppShell>();
        services.AddTransient<FruitsPage>();
        services.AddTransient<PetsPage>();
    }

    static void RegisterViewModels(IServiceCollection services)
    {
        services.AddTransient<AppShellViewModel>();
        services.AddTransient<FruitsViewModel>();
        services.AddTransient<PetsViewModel>();
    }
}
