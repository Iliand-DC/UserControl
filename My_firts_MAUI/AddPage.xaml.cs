namespace My_firts_MAUI;

public partial class AddPage : ContentPage
{
	Managment managment = new Managment();
	public AddPage()
	{
		InitializeComponent();
	}
	private void OnAddButton(object sendet, EventArgs e)
	{
		string name = UserName.Text;
		int age = Convert.ToInt32(UserAge.Text);
		string password = Password.Text;
		managment.AppendUser(name, age, password);
		Navigation.PopAsync();
	}
}
