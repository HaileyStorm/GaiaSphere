namespace GaiaSphere;

public partial class SearchPage : ContentPage
{

	public SearchPage()
	{
		InitializeComponent();

		Charts.ResultsChart.Instance.LVCChart = Chart;
	}

	private void OnSearchClicked(object sender, EventArgs e)
	{
		
	}
}