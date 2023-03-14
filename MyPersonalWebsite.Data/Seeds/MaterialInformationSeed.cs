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
    public class MaterialInformationSeed : IEntityTypeConfiguration<MaterialInformation>
    {

        private readonly int[] _ids;

        public MaterialInformationSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<MaterialInformation> builder)
        {
            builder.HasData(
                   new MaterialInformation
                   {
                       Id = 1,
                       Name = "Dell Insprion 5515 Laptop",
                       Code = "1000000",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       Description="",
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new MaterialInformation
                   {
                       Id = 2,
                       Name = "Apple Macbook Pro 13",
                       Code = "1000002",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       Description = "",
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                      new MaterialInformation
                      {
                          Id = 3,
                          Name = "MSI 32 Curve Monitor",
                          Code = "1000003",
                          CreatedById = 1,
                          ModifiedById = null,
                          IsActive = true,
                          Description = "",
                          // UpdatedDate = DateTime.Now,
                          CreatedDate = DateTime.Now
                      },
                   new MaterialInformation
                   {
                       Id = 4,
                       Name = "Microsoft Mouse",
                       Code = "1000004",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       Description = "",
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new MaterialInformation
                   {
                       Id = 5,
                       Name = "Windows 11 Kutulu Lisans",
                       Code = "1000005",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       Description = "",
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },
                   new MaterialInformation
                   {
                       Id = 6,
                       Name = "100 Watt Type C Adaptör",
                       Code = "1000006",
                       CreatedById = 1,
                       ModifiedById = null,
                       IsActive = true,
                       Description = "",
                       // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   });






        }
    }

}
