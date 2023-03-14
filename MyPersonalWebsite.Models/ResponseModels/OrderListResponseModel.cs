using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models.ResponseModels
{
    public class OrderListResponseModel
    {
        public string CustomerOrderNo { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public decimal Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }
        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Note { get; set; }
        public int StatusId { get; set; }
        public string StatusDesc { get; set; }
    }
   
        

    
}
