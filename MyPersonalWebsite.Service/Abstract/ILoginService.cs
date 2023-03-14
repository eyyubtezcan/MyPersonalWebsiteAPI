
using MyPersonalWebsite.Data.Entities;
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
    public interface ILoginService
    {
        ServiceResult<LoginResponseModel> Login(LoginRequestModel model);
        ServiceResult<bool> IsLoggedIn(string token, string sessionId, int userId);
    }
}
