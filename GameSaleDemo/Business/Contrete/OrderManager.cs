using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Business.Contrete
{
    public class OrderManager : IOrderService
    {
        public void Add(Game game, User user)
        {
            Console.WriteLine(user.FirstName+ " bought "+ game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName +  " deleted");
        }

        public void GameSale(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(user.FirstName+ " "+ "bought " + game.GameName+ " with "+ campaign.Discount + "% and " + campaign.CampaignName);
        }

       
    }
}
