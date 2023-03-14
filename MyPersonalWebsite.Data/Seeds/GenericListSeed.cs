using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Data.Seeds
{
    public class GenericListSeed : IEntityTypeConfiguration<GenericList>
    {

        private readonly int[] _ids;

        public GenericListSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<GenericList> builder)
        {
            builder.HasData(
                   new GenericList
                   {
                       Id = 1,
                       TypeName = "Miktar",
                       Name = "Adet",
                       Code = "100",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new GenericList
                   {
                       Id = 2,
                       TypeName = "Miktar",
                       Name = "Koli",
                       Code = "101",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new GenericList
                   {
                       Id = 3,
                       TypeName = "Miktar",
                       Name = "Paket",
                       Code = "103",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new GenericList
                   {
                       Id = 4,
                       TypeName = "Miktar",
                       Name = "Palet",
                       Code = "104",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new GenericList
                   {
                       Id = 5,
                       TypeName = "Ağırlık",
                       Name = "Kg",
                       Code = "200",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new GenericList
                   {
                       Id = 6,
                       TypeName = "Ağırlık",
                       Name = "Ton",
                       Code = "201",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   });


        }
    }

}
