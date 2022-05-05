using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace GaiaSphere;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		LiveCharts.Configure(config =>
			config
				.AddSkiaSharp()
				.AddDefaultMappers()
				.AddDarkTheme()
			);
	}
}
