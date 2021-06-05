using GameSaleDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleDemo.Entity.Concrete
{
    public class Campaign:IEntity
    {
        public string CampaignName { get; set; }
        public short Discount { get; set; }
    }
}
