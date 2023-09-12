using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Models.Input
{
    public class CartDetailDTO
    {
            public int? CartId { get; set; }
            public int?UserId { get; set; }
            public DateTime? CreationDate { get; set; }  
    }
}
