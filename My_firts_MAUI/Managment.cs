using System;
namespace My_firts_MAUI
{
    public class Managment
    {
        ApplicationContext db = new ApplicationContext();
        //Добавление данных
        public void AppendUser(String name, int age, String password)
        {
            User user = new User { Name = name, Age = age, Password = password }; // Создаём нового пользователя
            db.Users.AddAsync(user); // Добавляем его в базу данных асинхронно
            db.SaveChanges(); // Сохраняем изменения

        }
        // Получение всех данных
        public List<User> GetAllUsers()
        {
            var users = db.Users.ToList(); // получаю объекты из бд в виде списка
            return users;
            
        }
        // Существует ли пользователь с заданным именем
        private bool UserExist(String name)
        {
            User? user = db.Users.FirstOrDefault(p => p.Name == name);
            if (user != null)
                return true;
            else return false;
        }
        // Удаление пользователя по имени
        public void DeleteByName(String name)
        {
            var users = db.Users.ToList();
            if (UserExist(name)) // Если такой пользователь есть, то находим его и удаляем
            {
                User? user = users.FirstOrDefault(p => p.Name == name);
                if (user != null)
                    db.Users.Remove(user);
                db.SaveChanges();
            }
            else Console.WriteLine("Пользователя с таким именем не существует.");
        }
        // Редактирование данных о пользователе
        public void Edit(String name, String newName)
        {
            var users = db.Users.ToList();
            if (UserExist(name))
            {
                User? user = users.FirstOrDefault(p => p.Name == name);
                user.Name = newName;
                db.SaveChanges();
            }
            else Console.WriteLine("Пользователя с таким именем не существует.");
        }
        // Получить доступ к пользователю по имени
        public int GetAccess(String name, String password)
        {
            var users = db.Users.ToList();
            if (UserExist(name))
            {
                User? user = users.FirstOrDefault(p => p.Name == name);
                if (PasswordChecker.Check(user, password))
                    return 0;
                else return 1;
            }
            else
                return 2;
        }
    }
}

