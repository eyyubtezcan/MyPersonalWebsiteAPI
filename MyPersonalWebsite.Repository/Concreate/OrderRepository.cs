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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private PersonalWebDbContext _dbContext;

        public OrderRepository (PersonalWebDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}

