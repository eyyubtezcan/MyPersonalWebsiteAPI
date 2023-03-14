using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Repository.Concreate
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private PersonalWebDbContext _dbContext;

        public UserRepository(PersonalWebDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}

