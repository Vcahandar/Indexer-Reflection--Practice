using ServiceLayer.Exceptions;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public string Registers(string username, string email, string password)
        {
            try
            {
                var result = GetAllEmails();

                if (result.Contains(email))
                {
                    throw new RegisterException(ResponseMassage.InvalidRegisterMassage);
                }

                return ResponseMassage.SuccessRegisterMassage;


            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        private List<string> GetAllEmails()
        {
            return new List<string>() { "pervin12@gmail.com", "aqshin555@gmail.com", "ali555@gmail.com", "elekber555@gmail.com" };
        }
    }
}
