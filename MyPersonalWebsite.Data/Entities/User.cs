using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPersonalWebsite.Data.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {     
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string EncryptedPassword { get; set; }
        public DateTime ExpireDate { get; set; }
        public int BadLoginAttempts { get; set; }
        public string ActivationHash { get; set; }
    }
}
