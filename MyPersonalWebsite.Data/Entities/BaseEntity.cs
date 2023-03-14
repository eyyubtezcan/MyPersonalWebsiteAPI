using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedById { get; set; }

        public int? ModifiedById { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            //UpdatedDate = DateTime.Now;
            //IsDeleted = false;
            IsActive = true;
            CreatedById = 1;
          

        }
    }
}
