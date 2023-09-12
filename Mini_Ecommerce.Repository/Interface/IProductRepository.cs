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

		Task<int> AddProductDetailsAsync(ProductDetailDTO productDetail);

		Task<int> UpdateUserDetailsAsync(ProductDetailDTO productDetail);

		Task<int> DeleteUserDetailsAsync(int Id);
	}
}
