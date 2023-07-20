namespace My_firts_MAUI;

public partial class AllUsers : ContentPage
{
	public List<User> users;
	string usersData;
	Managment managment = new Managment();
	public AllUsers()
	{
		InitializeComponent();
		usersData = "";
		users = managment.GetAllUsers();
		List<string> usersToStrings = new List<string>();
		foreach (var user in users)
		{
			usersToStrings.Add(user.ToString());
		}
		//foreach (var user in users)
		//{
		//	usersData += $"{user.Id}. Имя: {user.Name} | Возраст: {user.Age}\n";
		//}
		BindingContext = usersToStrings;
	}
}
