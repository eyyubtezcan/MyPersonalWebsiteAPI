using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Data.Entities
{
    [Table("Config")]
    public class Config : BaseEntity
    {
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Value { get; set; }


    }
}
