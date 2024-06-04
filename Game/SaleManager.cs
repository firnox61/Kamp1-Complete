using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class SaleManager : ISaleService
    {
        public void Sale(User user, Game game, Campaign campaign)
        {
            if(user.Id==game.UserId && campaign!=null)
            {
                Console.WriteLine("Kullanici:" + user.Ad+ "\n" + "Oyun adı:" + game.GameName+"\n"+"Kampanya:"+ campaign.CampaignName);
                Console.WriteLine("BAşarılı bir şekilde oyun satışı yapılmıştır");
            }
            else
            {
                Console.WriteLine("Oyun sahibi tanımsız!!!!");
            }

        }
    }
}
