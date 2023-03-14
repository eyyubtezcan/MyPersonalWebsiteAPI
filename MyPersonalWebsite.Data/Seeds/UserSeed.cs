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
    public class UserSeed : IEntityTypeConfiguration<User>
    {

        private readonly int[] _ids;

        public UserSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                   new User
                   {
                       Id = 1,
                       Name = "System",
                       LastName = "",
                       Email = "eyyub.tezcan@gmail.com",
                       UserName = "System",
                       PhoneNumber = "",
                       ExpireDate = DateTime.Now.AddDays(30),
                       BadLoginAttempts = 0,
                       ActivationHash = "",
                       CreatedById = 1,
                       EncryptedPassword = "",
                       ModifiedById = null,
                       IsActive = false,
                      // UpdatedDate = DateTime.Now,
                       CreatedDate = DateTime.Now
                   },

            new User
                {
                    Id = 2,
                    Name = "Eyyüb",
                    LastName = "Tezcan",
                    Email="eyyub.tezcan@gmail.com",
                    UserName = "eyyub.tezcan@gmail.com",
                    PhoneNumber ="05375140784",
                    ExpireDate=DateTime.Now.AddDays(30),
                    BadLoginAttempts=0,
                    ActivationHash="",
                    CreatedById=1,
                    EncryptedPassword="",
                    ModifiedById=null,                    
                    IsActive = true,
                    //UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now
                });


        }
    }
 
}
