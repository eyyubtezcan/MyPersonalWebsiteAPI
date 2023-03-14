using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models.Enums
{
    
        public enum OrderStatusEnums
        {
            OrderReceived=1,
            OnTheWay=2,
            AtDistributionCenter=3,
            OutForDelivery=4,
            Delivered=5,
            DeliveryFailed=6
        }
   
}
