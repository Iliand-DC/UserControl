namespace My_firts_MAUI;

public partial class AccessPage : ContentPage
{
	Managment managment = new Managment();
	public AccessPage()
	{
		InitializeComponent();
	}
	private void AccessButtonClicked(object sender, EventArgs e)
	{
		string? name = UserName.Text;
		string? password = UserPassword.Text;
		managment.GetAccess(name, password);
		UserName.Text = "";
		UserPassword.Text = "";
	}
}
