using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
