using System;
namespace My_firts_MAUI
{
	public interface IPrinter
	{
		public static string Print(User user)
		{
			return $"  {user.Id}. {user.Name} - {user.Age}\n";
		}
	}
}

