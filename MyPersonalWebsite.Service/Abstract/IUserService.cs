using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Service.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Service.Abstract
{
    public interface IUserService
    {
        ServiceResult<bool> AddUser(UserRequestModel user);
        ServiceResult<List<User>> GetUsers(UserFilterModel filterModel);
        ServiceResult<Models.ViewModels.LoginResponseModel> Login(LoginRequestModel user);
    }
}
