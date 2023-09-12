using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Interface
{
    public interface ICartsDetailsRepository
    {
        Task<CartDetailResult> RepoGetAllCartDetailsAsync();
        Task<CartDetailDTO> RepoGetCartDetailsByIdAsync(int Id);
        Task<int> RepoInsertCartDetailsAsync(CartDetailDTO user);
        Task<int> RepoDeleteCartDetailsByIdAsync(Int64 Id);
        Task<int> RepoUpdateCartDetailsByIdAsync(CartDetailDTO user);
    }
}
