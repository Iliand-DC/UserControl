namespace My_firts_MAUI;

public partial class UpdatePage : ContentPage
{
    public string editUserName;
	public UpdatePage()
	{
		InitializeComponent();
	}
    private async void ToEditPage(object sender, EventArgs e)
    {
        editUserName = UserName.Text;
        UserName.Text = "";
        await Navigation.PushAsync(new EditPage
        {
            BindingContext = editUserName
        });
    }
}
