namespace GaiaSphere;

public partial class SearchPage : ContentPage
{

	public SearchPage()
	{
		InitializeComponent();

		Charts.ResultsChart.Instance.LVCChart = Chart;
		Loaded += Charts.ResultsChart.Instance.OnPageLoaded;
		NavigatedTo += Charts.ResultsChart.Instance.OnPageLoaded;
	}

	private void OnSearchClicked(object sender, EventArgs e)
	{
		
	}
}