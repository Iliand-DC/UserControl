namespace My_firts_MAUI;
public partial class MainPage : ContentPage
{
	Managment managment = new Managment();
	public MainPage()
	{
        InitializeComponent();
    }

	private void OnShowClicked(object sender, EventArgs e)
	{
		var users = managment.GetAllUsers();
		UsersData.Text = "";
		foreach (var user in users)
		{
			UsersData.Text += IPrinter.Print(user);
        }
	}
    private async void ToAddPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddPage());
    }
	private async void ToAccessPage(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AccessPage());
	}
}