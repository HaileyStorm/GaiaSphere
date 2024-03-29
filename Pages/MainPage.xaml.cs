﻿namespace GaiaSphere;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnPageLoaded(object sender, EventArgs e)
	{
		DisplayInfo.Density = Window.DisplayDensity;
		DisplayInfo.WidthPx = DeviceDisplay.Current.MainDisplayInfo.Width;
		DisplayInfo.WidthPt = DisplayInfo.WidthPx / DisplayInfo.Density;
		DisplayInfo.HeightPx = DeviceDisplay.Current.MainDisplayInfo.Height;
		DisplayInfo.HeightPt = DisplayInfo.HeightPx / DisplayInfo.Density;
		DisplayInfo.Orientation = DeviceDisplay.Current.MainDisplayInfo.Orientation;
		DisplayInfo.Rotation = DeviceDisplay.Current.MainDisplayInfo.Rotation;

		WindowInfo.WidthPt = Width;
		WindowInfo.WidthPx = Width * DisplayInfo.Density;
		WindowInfo.HeightPt = Height;
		WindowInfo.HeightPx = Height * DisplayInfo.Density;

		Window.DisplayDensityChanged += new EventHandler<DisplayDensityChangedEventArgs>( delegate (object sender, DisplayDensityChangedEventArgs e)
		{
			DisplayInfo.Density = Window.DisplayDensity;
		}) + Charts.Chart.OnDisplayInfoChanged_All;
		DeviceDisplay.Current.MainDisplayInfoChanged += new EventHandler<DisplayInfoChangedEventArgs>( delegate (object sender, DisplayInfoChangedEventArgs e)
		{
			DisplayInfo.WidthPx = e.DisplayInfo.Width;
			DisplayInfo.WidthPt = DisplayInfo.WidthPx / DisplayInfo.Density;
			DisplayInfo.HeightPx = e.DisplayInfo.Height;
			DisplayInfo.HeightPt = DisplayInfo.HeightPx / DisplayInfo.Density;
			DisplayInfo.Orientation = e.DisplayInfo.Orientation;
			DisplayInfo.Rotation = e.DisplayInfo.Rotation;
		}) + Charts.Chart.OnDisplayInfoChanged_All;
		SizeChanged += new EventHandler( delegate (object sender, EventArgs e)
		{
			WindowInfo.WidthPt = Width;
			WindowInfo.WidthPx = Width * DisplayInfo.Density;
			WindowInfo.HeightPt = Height;
			WindowInfo.HeightPx = Height * DisplayInfo.Density;
		}) + Charts.Chart.OnWindowInfoChanged_All;
	}
}

