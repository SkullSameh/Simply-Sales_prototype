namespace VX12;

public partial class App : Application
{
    public static DataTrans.DataT DB { get; private set; }
    public App(DataTrans.DataT trans)
	{
		InitializeComponent();

		MainPage = new AppShell();
        DB = trans;
    }
}
