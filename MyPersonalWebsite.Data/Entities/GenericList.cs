using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Data.Entities
{
    public class GenericList:BaseEntity
    {
        public string Code { get; set; } // Code alanı ile generic verilerin ayrışması sağlanacak
        public string TypeName { get; set; } // Miktar Birim - Ağırlık Birim gibi
        public string Name { get; set; } //Adet, Koli, Paket, Palet,Kg, Ton
        //public string? Value { get; set; } //Bu alan ilerde lazım olabilir
       
    }
}
