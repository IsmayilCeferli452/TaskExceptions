using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Helpers.Exceptions;
using Task.Services;

namespace Task.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public void Login()
        {
            try
            {
            Email: Console.WriteLine("Please add your email:");
                string email = Console.ReadLine();

                if (string.IsNullOrEmpty(email))
                {
                    goto Email;
                }

            Password: Console.WriteLine("Please add your password:");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    goto Password;
                }

                var result = _userService.Login(_userService.GetAll(), email, password);

                if (result == true)
                {
                    Console.WriteLine("Login successfull !");
                }
                else
                {
                    throw new UserLoginFailedException("Login failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CheckPass()
        {
            try
            {
            Email: Console.WriteLine("Please add your email:");
                string email = Console.ReadLine();

                if (string.IsNullOrEmpty(email))
                {
                    goto Email;
                }

            Pass: Console.WriteLine("Please add your passwrod:");
                string password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    goto Pass;
                }

                var result = _userService.CheckPass(email, password);

                if (result == true)
                {
                    Console.WriteLine("Login successfull !");
                }
                else
                {
                    throw new UserLoginPasswordFormatWrongException("Password format is wrong.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
