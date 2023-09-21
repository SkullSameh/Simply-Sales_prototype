using Microsoft.Extensions.Logging;

namespace VX12;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string _Path = Path.Combine(FileSystem.AppDataDirectory, "Final2.db");
        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<DataTrans.DataT>(s, _Path));

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
