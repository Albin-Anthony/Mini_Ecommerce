using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Interface
{
    public interface IShopCartsService
    {
        Task<ResultArgs> SerGetAllCartDetailsAsync();
        Task<ResultArgs> SerGetCartDetailsByIdAsync(int Id);
        Task<ResultArgs> SerInsertCartDetailsAsync(CartDetailDTO user);
        Task<ResultArgs> SerDeleteCartByIdAsync(int Id);
        Task<ResultArgs> SerUpdateCartDetailsByIdAsync(CartDetailDTO cart);
      
    }
}
