namespace GaiaSphere;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();

		DataModel.Candidate.CandidateSelected += OnCandidateSelected;
	}

	public void OnCandidateSelected(object candidate, EventArgs e)
	{
		//TODO: Update the details view, based on candidate
	}

	private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();
	}
}