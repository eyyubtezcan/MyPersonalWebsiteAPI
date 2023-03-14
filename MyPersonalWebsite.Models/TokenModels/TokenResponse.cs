using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Models.TokenModels
{
    public class TokenResponse
    {
    
        public TokenResponse(string Token, DateTime ExpiryDate)
        {
            this.Token = Token;
            this.ExpiryDate = ExpiryDate;
        }

        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
