namespace GaiaSphere;

public partial class TransitsPage : ContentPage
{
	public TransitsPage()
	{
		InitializeComponent();
	}

    private void OnNavigatedTo(object sender, NavigatedToEventArgs e)
    {
		ResultsList.UpdateSelection();

		//TODO: Update TransitsChart, based on Candidate.SelectedCandidate
    }
}