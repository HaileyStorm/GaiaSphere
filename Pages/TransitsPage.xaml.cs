namespace GaiaSphere;

public partial class TransitsPage : ContentPage
{
	public TransitsPage()
	{
		InitializeComponent();

		DataModel.Candidate.CandidateSelected += OnCandidateSelected;
		
		Charts.TransitsChart.Instance.LVCChart = TransitsPageChart;
		Loaded += Charts.TransitsChart.Instance.OnPageLoaded;
		NavigatedTo += Charts.TransitsChart.Instance.OnPageLoaded;
	}

	/// <summary>
	/// Will get called however the selected candidate is changed (e.g. anywhere ResultsListView is used, anythign working directly with the Candidate class, etc.) - 
	/// not just when the selection is changed here.
	/// </summary>
	/// <param name="candidate"></param>
	/// <param name="e"></param>
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