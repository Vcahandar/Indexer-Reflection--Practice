using ServiceLayer.Services;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.Controller
{
    public class AccountController
    {
        private readonly IAccountService _service;

        public AccountController()
        {
            _service = new AccountService();
        }


        public void GetPeopleBySalary()
        {
            var result = _service.GetPeopleCondition(m => m.Salary > 1000);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Salary}");
            }
        }

        public void GetPeopleByName()
        {
            var result = _service.GetPeopleCondition(m => m.Name.Contains("C"));
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Surname} ");

            }

        }
    }
}
