using Mini_Ecommerce.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Models.Output
{
    public class UserDetailResult
    {
        public UserDetailDTO? ProfileUserDetails { get; set; }
        public List<UserDetailDTO>? ProfileUserDetailsList { get; set; }
    }
}
