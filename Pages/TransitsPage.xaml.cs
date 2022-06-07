namespace GaiaSphere;

public partial class TransitsPage : ContentPage
{
	public TransitsPage()
	{
		InitializeComponent();
		DataModel.Candidate.CandidateSelected += OnCandidateSelected;
	}

	public void OnCandidateSelected(object candidate, EventArgs e)
    {
		//TODO: Update TransitsChart, based on candidate
		Charts.TransitsChart.AddValue(1);
	}

	private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();
    }
}