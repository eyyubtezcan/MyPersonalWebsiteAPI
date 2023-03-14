using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyPersonalWebsite.Models.ResponseModels
{
    public class OrderCreateResponseModel
    {   
        public int SystemOrderNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public bool Status { get; set; }
        public string ErrorDescription { get; set; }

    }
}
