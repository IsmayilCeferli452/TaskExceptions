using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Services.Interfaces
{
    public interface IUserService
    {
        public User[] GetAll();

        public bool Login(User[] users, string email, string password);

        public bool CheckPass(string email, string password);
    }
}

