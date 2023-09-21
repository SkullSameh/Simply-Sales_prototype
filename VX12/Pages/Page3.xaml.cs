
namespace VX12;

public partial class Page3 : ContentPage
{
	public Page3()
	{
        InitializeComponent();
        App.DB.Init();
        Sales_Rep_List.ItemsSource = App.DB.GetSalesList();
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        App.DB.Add(new Models.Sales
        {
            S_Name = UserName.Text,
            S_L_Name = LastName.Text,
            S_Tel = Tel.Text
        });

        Sales_Rep_List.ItemsSource = App.DB.GetSalesList();
    }

    int ID;
    private void Delete_Clicked(object sender, EventArgs e)
    {
        App.DB.DeleteOneSales(ID);
        Sales_Rep_List.ItemsSource = App.DB.GetSalesList();
    }

    private void Sales_Rep_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var tap = e.Item as Models.Sales;
        ID = tap.S_ID;
    }
}