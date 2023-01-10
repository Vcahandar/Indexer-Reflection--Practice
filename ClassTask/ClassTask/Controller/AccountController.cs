using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Controller
{
    public class AccountController
    {
        private readonly IAccountService _service;


        public AccountController()
        {
            _service = new AccountService();
        }

        public void Register()
        {
            Console.WriteLine("Add Your Username :");
            string username=Console.ReadLine();

            Console.WriteLine("Add Your Email :");
            string email = Console.ReadLine();

            Console.WriteLine("Add Your Password :");
            string password = Console.ReadLine();

            var result = _service.Registers(username, email, password);
            Console.WriteLine(result);
        }

    }
}
