namespace My_firts_MAUI;

public partial class AccessPage : ContentPage
{
	public enum AccessCode: int
	{
		Access = 0,
		Denied = 1,
		UserNotExist = 2
	}

	Managment managment = new Managment();
	public AccessPage()
	{
		InitializeComponent();
	}
	private void AccessButtonClicked(object sender, EventArgs e)
	{
		string? name = UserName.Text;
		string? password = UserPassword.Text;
		var access = managment.GetAccess(name, password);
		if (access == 0)
			DisplayAlert("Доступ к пользователю получен", "", "Ok");
		else if (access == 1)
			DisplayAlert("В доступе отказано", "", "Ok");
		else DisplayAlert("Такого пользователя не существует", "", "Ок");
		UserName.Text = "";
		UserPassword.Text = "";
	}
}
