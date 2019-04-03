using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUser
{
    public class User
    {
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    surname = value;
                }

                else
                {
                    throw new Exception("Фамилия не может быть пустой!");
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }

                else
                {
                    throw new Exception("Имя не может быть пустым!");
                }
            }
        }

        public string Patronymic { get; set; }

        private DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (DateTime.Now > value)
                {
                    birthday = value;
                }

                else
                {
                    throw new Exception("Введите корректную дату!");
                }
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthday.Year;

                if (DateTime.Now.Month <= Birthday.Month && DateTime.Now.Day < Birthday.Day)
                {
                    age = age - 1;
                }

                return age;
            }
        }

        public User(string surname, string name, string patronymic, DateTime birthday)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthday = birthday;
        }
    }
}

