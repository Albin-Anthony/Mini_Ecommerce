using Mini_Ecommerce.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Interface
{
    public interface IRegisterRepositorycs
    {
        Task<int> SaveRegisterDetailsAsync(RegisterDTO registerDetails);
    }
}
