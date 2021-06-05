using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Abstract
{
    public interface IGameService
    {
         void Add(Game game);
         void Update(Game game);
         void Delete(Game game);
    }
}
