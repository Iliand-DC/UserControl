namespace My_firts_MAUI;
public partial class MainPage : ContentPage
{
    string usersData;
	Managment managment = new Managment();
	public MainPage()
	{
        InitializeComponent();
    }

	private async void OnShowClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AllUsers());
	}
    private async void ToAddPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddPage());
    }
	private async void ToAccessPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AccessPage());
	}
    private async void ToUpdatePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UpdatePage());
    }
    private async void ToDeletePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeletePage());
    }
}