namespace GaiaSphere;

public partial class ResultsListView : ContentView
{
	

	public ResultsListView()
	{
		InitializeComponent();
	}

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		Candidate.SelectedCandidate = (Candidate)e.SelectedItem;
	}

	/// <summary>
	/// Used to synchronize selected candidate between Pages (instances of ResultsListView). Called by Pages' NavigatedTo events.
	/// </summary>
	public void UpdateSelection()
    {
		ResultsList.SelectedItem = Candidate.SelectedCandidate;
    }
}