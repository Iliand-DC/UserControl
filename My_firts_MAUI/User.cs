using System;
namespace My_firts_MAUI
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string ToString()
        {
            return $"{Id}. Имя: {Name} | Возраст: {Age}";
        }
    }
}

