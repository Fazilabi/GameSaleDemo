using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Contrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
           if(user.DateOfBirth==new  DateTime(1989) && user.FirstName == "Fazil")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
