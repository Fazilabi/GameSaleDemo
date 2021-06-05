using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Contrete
{
    public class UserManager : IUserService
    {
        public void Add( User user)
        {
            Console.WriteLine(user.FirstName +" "+ user.LastName + " user added");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " user deleted");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " user updated");
        }
    }
}
