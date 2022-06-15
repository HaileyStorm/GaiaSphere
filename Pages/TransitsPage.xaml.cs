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
		//TODO: Update TransitsChart, based on candidate (override the getter for TransitsChart.Series instead?)
		Charts.TransitsChart.Instance.AddValue(1);
		Chart.CoreChart.Update();
	}

	private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();
    }
}