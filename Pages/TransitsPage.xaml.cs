namespace GaiaSphere;

public partial class TransitsPage : ContentPage
{
	public TransitsPage()
	{
		InitializeComponent();

		DataModel.Candidate.CandidateSelected += OnCandidateSelected;
		
		Charts.TransitsChart.Instance.LVCChart = Chart;
		Loaded += Charts.TransitsChart.Instance.OnPageLoaded;
		NavigatedTo += Charts.TransitsChart.Instance.OnPageLoaded;
	}

	public void OnCandidateSelected(object candidate, EventArgs e)
    {
		//TODO: Update TransitsChart, based on candidate (override the getter for TransitsChart.Series instead?)
		Charts.TransitsChart.Instance.AddValue(1);
	}

	private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();
    }

    private void OnPageLoaded(object sender, EventArgs e)
    {
		
	}
}