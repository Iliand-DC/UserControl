namespace My_firts_MAUI;

public partial class DeletePage : ContentPage
{
	Managment managment = new Managment();
	public DeletePage()
	{
		InitializeComponent();
	}
	private void DeleteUser(object sender, EventArgs e)
	{
		managment.DeleteByName(DeleteUserName.Text);
		Navigation.PopAsync();
	}
}
