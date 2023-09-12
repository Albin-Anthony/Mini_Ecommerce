using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Interface
{
	public interface IproductService
	{
		Task<ResultArgs> AddProductDetailsAsync(ProductDetailDTO productDetail);
		
		Task<ResultArgs> GetUserDetailsAsync();
		Task<ResultArgs> GetUserDetailsByIdAsync(int Id);

		Task<ResultArgs> UpdateUserDetailsAsync(ProductDetailDTO productDetail);

		Task<ResultArgs> DeleteUserDetailsAsync(int Id);

	}
}
