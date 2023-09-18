using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Interface
{
    public interface IUserDetailsService
    {
        Task<ResultArgs> SerGetUserDetailsByIdAsync(int Id);
        Task<ResultArgs> SerInsertUserDetailsAsync(UserDetailDTO user);
        Task<ResultArgs> SerUpdateUserDetailsAsync(UserDetailDTO userDetail);
    }
}
