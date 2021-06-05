using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Contrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" named game added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " named game deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " named game updated");
        }
    }
}
