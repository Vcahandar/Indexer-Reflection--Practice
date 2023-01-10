using DomainLayer.Models;
using ServiceLayer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AccountService : IAccountService
    {
        public List<Person> GetPeopleCondition(Predicate<Person> predicate)
        {

            List<Person> people = GetAll();
            return people.FindAll(predicate);
        }

        private List<Person> GetAll()
        {
            List<Person> people = new()
            {
            new Person() {Id=1,Name="Cahandar",Surname="Velibeyli",Salary=80},
            new Person() {Id=2,Name="Mirze",Surname="Beshirzade",Salary=1500},
            new Person() {Id=3,Name="Ceyhun",Surname="Abbasov",Salary=2000},
            new Person() {Id=4,Name="Nurlan",Surname="Mecidli",Salary=900}

            };
        
            return people;
            
        }
       

       
            
            
        
        
    }
}
