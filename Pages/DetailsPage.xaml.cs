namespace GaiaSphere;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();

		DataModel.Candidate.CandidateSelected += OnCandidateSelected;
	}

	/// <summary>
	/// Will get called however the selected candidate is changed (e.g. anywhere ResultsListView is used, anythign working directly with the Candidate class, etc.)
	/// </summary>
	/// <param name="candidate"></param>
	/// <param name="e"></param>
	public void OnCandidateSelected(object candidate, EventArgs e)
	{
		//TODO: Update the details view, based on candidate
	}

	private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();
	}
}