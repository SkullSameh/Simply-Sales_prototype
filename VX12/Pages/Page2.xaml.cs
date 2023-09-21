namespace VX12;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
        App.DB.Init();
        Client_List.ItemsSource = App.DB.GetClientList();
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DB.Add(new Models.Client
        {
            C_Name = Name.Text,
            C_L_Name = LastName.Text,
            C_Tel = Tel.Text
        }) ;

        Client_List.ItemsSource = App.DB.GetClientList();
    }

    int ID;

    private void Delete_Clicked(object sender, EventArgs e)
    {
        App.DB.DeleteOneClient(ID);
        Client_List.ItemsSource = App.DB.GetClientList();
    }

    private void Client_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Client;
        ID = tap.C_ID;
    }
}