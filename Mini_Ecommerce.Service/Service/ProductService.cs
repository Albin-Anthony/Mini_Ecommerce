using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Repository.Interface;
using Mini_Ecommerce.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Service
{
	public class ProductService : IproductService
	{
		private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
			_productRepository = productRepository;

		}

        //insert
        public async Task<ResultArgs> AddUserDetailsAsync(ProductDetailDTO productDetail)
		{
			var ResultArgs = new ResultArgs();

			var ResponseId = await _productRepository.AddUserDetailsAsync(productDetail);
			if (ResponseId == MessageCatlog.ErrorCodes.Success)
			{
				ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
				ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
			}
			else if (ResponseId == MessageCatlog.ErrorCodes.AlreadyExist)
			{
				ResultArgs.StatusCode = MessageCatlog.ErrorCodes.AlreadyExist;
				ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.Exist;
			}
			else
			{
				ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Failed;
				ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.Failed;
			}

			return ResultArgs;
		}

		public Task<ResultArgs> DeleteUserDetailsAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<ResultArgs> GetUserDetailsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ResultArgs> GetUserDetailsByIdAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<ResultArgs> UpdateUserDetailsAsync(ProductDetailDTO userDetailDTO)
		{
			throw new NotImplementedException();
		}
	}
}
