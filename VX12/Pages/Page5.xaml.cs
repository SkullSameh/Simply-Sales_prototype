namespace VX12;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
        App.DB.Init();
        Assignment.ItemsSource = App.DB.GetAssignmentList();

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Assignment.ItemsSource = App.DB.GetAssignmentList();
    }
    int C, S , main;
    private void Assignment_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Assignment;
        C = tap.C_Id;
        S = tap.S_Id;
        main = tap.Id;
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        App.DB.DeleteOneAssignment(main);
        Assignment.ItemsSource = App.DB.GetAssignmentList();
    }
}