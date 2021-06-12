using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Contrete
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine("User successfully added");
            }
            else
            {
                Console.WriteLine("User was not added");
            }
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
