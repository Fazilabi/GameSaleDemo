using GameSaleDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entity.Concrete
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }


    }
}
