using Gamer;

internal class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User();
        user1.Id = 1;
        user1.Ad = "Enes";
        user1.Soyad = "Eroglu";
        user1.DogumYili = 2000;
        user1.TcNo = "26485213500";
        //çalışabilmek için doğrulama sınıfına ihtiyacım var diyor
        UserManager userManager = new UserManager(new UserValidationManager());
        userManager.Add(user1);
        Game game1 = new Game();
        game1.GameId = 1;
        game1.GameName = "Batlefield1";
        game1.UserId = 1;
        Game game2 = new Game();
        game2.GameId = 2;
        game2.GameName = "Age Of Empires";
        game2.UserId = 2;
        SaleManager saleManager = new SaleManager();
        
        Campaign campaign1 = new Campaign();
        campaign1.Id = 1;
        campaign1.CampaignName = "Yaz indirimi";

        CampaignManager campaignManager = new CampaignManager(new CampaignValidationManager());
        campaignManager.Add(campaign1);

        saleManager.Sale(user1, game1,campaign1);

        saleManager.Sale(user1 , game1,null);









    }
}