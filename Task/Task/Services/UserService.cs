using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Services
{
    public class UserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Password = "rashad123",
            };

            User user2 = new()
            {
                Id = 2,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age = 22,
                Email = "rufat@gmail.com",
                Address = "Baki",
                Password = "rufat123",
            };

            User user3 = new()
            {
                Id = 3,
                Name = "Cavid",
                Surname = "Bashirov",
                Age = 30,
                Email = "cavid@gmail.com",
                Address = "Siyezen",
                Password = "cavid123",
            };

            User user4 = new()
            {
                Id = 4,
                Name = "Amirastan",
                Surname = "Mereyev",
                Age = 33,
                Email = "Amirastan@gmail.com",
                Address = "Xezer",
                Password = "amirastan123",
            };

            User user5 = new()
            {
                Id = 5,
                Name = "Esgerxan",
                Surname = "Bayramov",
                Age = 27,
                Email = "esgerxan@gmail.com",
                Address = "Berde",
                Password = "esgerxan123",
            };

            User user6 = new()
            {
                Id = 6,
                Name = "Behruz",
                Surname = "Aliyev",
                Age = 21,
                Email = "bahruz@gmail.com",
                Address = "Ordubad",
                Password = "behruz123",
            };

            return new User[] { user1, user2, user3, user4, user5, user6 };
        }

        public bool Login(User[] users, string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Email.Trim().ToLower().Equals(email) && user.Password.Trim().ToLower().Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckPass(string email, string password)
        {
            if (password.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
