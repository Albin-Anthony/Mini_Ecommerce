using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Interface
{
	public interface IProductRepository
	{
		Task<ProductDetailResults> GetUserDetailsAsync();

		Task<ProductDetailDTO> GetUserDetailsByIdAsync(int Id);

		Task<int> AddUserDetailsAsync(ProductDetailDTO userDetailDTO);

		Task<int> UpdateUserDetailsAsync(ProductDetailDTO userDetailDTO);

		Task<int> DeleteUserDetailsAsync(int Id);
	}
}
