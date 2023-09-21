namespace VX12;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
        App.DB.Init();
        Client.ItemsSource = App.DB.GetClientList();
        SalesL.ItemsSource = App.DB.GetSalesList();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Client.ItemsSource = App.DB.GetClientList();
        SalesL.ItemsSource = App.DB.GetSalesList();
    }

    int C_ID;
    int S_ID;
    private void Client_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Client;
        C_ID = tap.C_ID;
    }

    private void SalesL_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Sales;
        S_ID = tap.S_ID;
    }

    private void ADD_Clicked(object sender, EventArgs e)
    {
        App.DB.AddAssignment(new Models.Assignment
        {
            C_Id = C_ID,
            S_Id = S_ID
        });
    }
}