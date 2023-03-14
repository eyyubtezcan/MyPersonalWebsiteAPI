using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ResponseModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Repository.Abstract;
using MyPersonalWebsite.Repository.Concreate;
using MyPersonalWebsite.Service.Abstract;
using MyPersonalWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using MyPersonalWebsite.Models.Enums;

namespace MyPersonalWebsite.Service.Concreate
{
    public class MaterialService : IMaterialService
    {
        private readonly IOrderRepository _repository;
        private readonly IRepository<MaterialInformation> _materialRepository;

        public MaterialService(IRepository<MaterialInformation> materialRepository
            )
        {
           
            _materialRepository = materialRepository;
        }

    }
}
