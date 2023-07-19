namespace My_firts_MAUI;

public partial class EditPage : ContentPage
{
	Managment managment = new Managment();
	string oldName;
	public EditPage()
	{
		InitializeComponent();
	}
	private void SaveChanges(object sender, EventArgs e)
	{
		oldName = OldName.Text;
		managment.Edit(oldName, UserName.Text);
        Navigation.PopAsync();
    }
}
