using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Abstract
{
    interface IUserValidationService
    {
        bool Validate(User user);
       
    }
}
