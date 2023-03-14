using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPersonalWebsite.Data.Entities;

namespace MyPersonalWebsite.Data.Seeds
{
    public class OrderStatusSeed : IEntityTypeConfiguration<OrderStatus>
    {

        private readonly int[] _ids;

        public OrderStatusSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasData(
                   new OrderStatus
                   {
                       Id = 1,
                       Name = "Sipariş Alındı",
                       Description = "Sipariş Alındı",
                       Code = "100",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new OrderStatus
                   {
                       Id = 2,
                       Name = "Yola Çıktı",
                       Description = "Yola Çıktı",
                       Code = "101",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                      new OrderStatus
                   {
                       Id = 3,
                       Name = "Dağıtım Merkezinde",
                       Description = "Dağıtım Merkezinde",
                       Code = "102",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new OrderStatus
                   {
                       Id = 4,
                       Name = "Dağıtıma Çıktı",
                       Description = "Dağıtıma Çıktı",
                       Code = "103",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new OrderStatus
                   { 
                       Id = 5,
                       Name = "Teslim Edildi",
                       Description = "Teslim Edildi",
                       Code = "104",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new OrderStatus
                   {
                       Id = 6,
                       Name = "Teslim Edilemedi",
                       Description = "Teslim Edilemedi",
                       Code = "105",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   });






        }
    }

}
