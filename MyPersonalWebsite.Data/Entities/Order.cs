
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace MyPersonalWebsite.Data.Entities
{
    public class Order:BaseEntity
    {
        [Required]
        public string CustomerOrderNo{ get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public decimal Quantity { get; set; } 
        public string QuantityUnit { get; set; }
        public decimal Weight { get; set; }
        public string WeightUnit { get; set; }        
        public string Note { get; set; }
        public int StatusId { get; set; }
        public int MaterialId { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual MaterialInformation Material { get; set; }
    }

}
