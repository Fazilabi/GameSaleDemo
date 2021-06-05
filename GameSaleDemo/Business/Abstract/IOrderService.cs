using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Abstract
{
    public interface IOrderService
    {
        void GameSale(Game game, User user, Campaign campaign);
        void Add(Game game, User user);
        void Delete(Game game);
    }
}
