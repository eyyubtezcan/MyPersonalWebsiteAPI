using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models.ViewModels
{
    public class LoginResponseModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public string ErrorMessage { get; set; }
        public bool Succeeded { get; set; }
    }
}
