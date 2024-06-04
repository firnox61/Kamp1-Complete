using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class CampaignValidationManager : ICampaignValidationService
    {
        public bool CampaignValidaton(Campaign campaign)
        {
            if (campaign.Id == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
