using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Models.FilterModels;
using MyPersonalWebsite.Models.RequestModels;
using MyPersonalWebsite.Models.ViewModels;
using MyPersonalWebsite.Repository.Abstract;
using MyPersonalWebsite.Repository.Concreate;
using MyPersonalWebsite.Service.Abstract;
using MyPersonalWebsite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Service.Concreate
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) 
        {
            _repository = repository;
        }

        public ServiceResult<bool> AddUser(UserRequestModel user)
        {
            ServiceResult<bool> result = new ServiceResult<bool>();

            //nullcheck vs yapılacak

            _repository.AddAsync(new User()
            {
                Name = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.PhoneNumber,
                ExpireDate = DateTime.UtcNow.AddDays(30),
                BadLoginAttempts=0,
                IsActive=true,
                ActivationHash="",
                EncryptedPassword= EncryptDecryptHelper.Encrypt(user.Password)
            }) ;

            result.Result = true;

            result.Ok();

            return result;
        }

        public ServiceResult<List<User>> GetUsers(UserFilterModel filterModel)
        {
            ServiceResult<List<User>> res = new ServiceResult<List<User>>();

            //nullcheck vs yapılacak
            var users = _repository.GetAllQueryableAsync();

            if (filterModel.UserName is not null)
                users = users.Where(x => x.UserName == filterModel.UserName);

            if (filterModel.Email is not null)
                users = users.Where(x => x.Email == filterModel.Email);

            res.Result =  users.ToList();

            res.Ok();

            return res;
        }

        public ServiceResult<Models.ViewModels.LoginResponseModel> Login(LoginRequestModel model)
        {

            ServiceResult<Models.ViewModels.LoginResponseModel> result = new ServiceResult<Models.ViewModels.LoginResponseModel>();

            //this.ValidateUser(model);
            if (model == null)
            {
                result.Fail();
                result.Result.ErrorMessage = "Lütfen Kullanıcı adı ve şifrenizi giriniz";
            }
            else
            {
                var encryptedPassword = EncryptDecryptHelper.Encrypt(model.Password);


                var userData = _repository.
                    Where(x => x.UserName == model.UserName && x.EncryptedPassword == encryptedPassword).Result.FirstOrDefault();

                if(userData != null)
                {
                    Models.ViewModels.LoginResponseModel loginResult = new Models.ViewModels.LoginResponseModel()
                    {
                        Succeeded = true,
                        UserName = userData.UserName,
                        UserId= userData.Id.ToString()
                    };
                    result.Result = loginResult;
                    result.Ok();
                }
                else
                {
                    result.Result.ErrorMessage = "Lütfen geçerli bir Kullanıcı adı ve şifrenizi giriniz";
                    result.Fail();
                }

                //var userData = _userService.GetUsers(userfilterModel).Result.FirstOrDefault();
            }

            return result;
        }

     
    }
}
