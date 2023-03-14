using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models.RequestModels
{
    public class OrderStatusUpdateRequestModel
    {
        public string CustomerOrderNo { get; set; }
        public int StatusId { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}
