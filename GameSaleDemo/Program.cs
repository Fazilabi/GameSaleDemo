using GameSaleDemo.Business.Abstract;
using GameSaleDemo.Business.Contrete;
using GameSaleDemo.Entity.Concrete;
using System;

namespace GameSaleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { GameName= "Last of Us", Id=1, CategoryId=1, Price=199.99};
            Game game2 = new Game() {  GameName="Cyberpunk 2077", Id=2, CategoryId=1, Price=249.99};
            Game game3 = new Game() {  GameName="FarCry", Id=3, CategoryId=2, Price=159.99};


            User user1 = new User() {  Id=1, FirstName="Fazil", LastName="Gurban", NationalityId="251642136", DateOfBirth=new DateTime(1989)};
            User user2 = new User() {  Id=2, FirstName="Murad", LastName="Ali", NationalityId="251642826", DateOfBirth=new DateTime(1992,05,05)};
            User user3 = new User() {  Id=3, FirstName = "Tural", LastName="Veli", NationalityId="251642951", DateOfBirth=new DateTime(1995,03,10)};


            Campaign campaign1 = new Campaign() {  CampaignName="Spring sale" , Discount=30};
            Campaign campaign2 = new Campaign() {  CampaignName="Weekend sale" , Discount=50};
            Campaign campaign3 = new Campaign() {  CampaignName="Black Friday sale" , Discount=20 };

            GameManager gameManager = new GameManager();
            //gameManager.Add(game1);
            //gameManager.Add(game2);
            //gameManager.Add(game3);
            //gameManager.Delete(game2);
            //gameManager.Update(game3);
            //Console.WriteLine("------------------------------");
            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(user1);
            //userManager.Add(user1);
            //userManager.Add(user2);
            //userManager.Add(user3);
            //userManager.Update(user1);
            //userManager.Delete(user2);
            //Console.WriteLine("------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            //campaignManager.Add(campaign1);
            //campaignManager.Add(campaign2);
            //campaignManager.Add(campaign3);
            //campaignManager.Delete(campaign2);
            //campaignManager.Update(campaign1);


            OrderManager saleManager = new OrderManager();
            //saleManager.GameSale(game1, user2, campaign2);
            //saleManager.GameSale(game2, user1, campaign3);
            //saleManager.Add(game2, user1);


        }
    }
}
