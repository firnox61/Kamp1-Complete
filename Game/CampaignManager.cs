using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class CampaignManager : ICampaignService

    {
        ICampaignValidationService _campaignValidationService;
        public CampaignManager(ICampaignValidationService campaignValidationService)
        {
            _campaignValidationService = campaignValidationService;
        }

        public void Add(Campaign campaign)
        {
            if(_campaignValidationService.CampaignValidaton(campaign)==true)
            {
                Console.WriteLine("Kampanya başarılı bir şekilde eklendi");
            }
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde güncellendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde silindi");
        }
    }
}
