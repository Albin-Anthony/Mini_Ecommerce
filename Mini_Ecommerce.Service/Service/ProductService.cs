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

		public async Task<ResultArgs> GetUserDetailsAsync()
		{
			ResultArgs ResultArgs = new ResultArgs();
			try
			{
				var objUserDetail = await _productRepository.GetUserDetailsAsync();

				ResultArgs.MessageTitle = MessageCatlog.MessageTitle.UserDetails;

				if (objUserDetail != null)
				{
					ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
					ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
					ResultArgs.ResultData = objUserDetail.UserDetailsList;
				}
				else
				{
					ResultArgs.StatusCode = MessageCatlog.ErrorCodes.NoRecordFound;
					ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.NoRecordFound;
				}
			}
			catch (Exception ex)
			{

			}
			return ResultArgs;
		}

		public Task<ResultArgs> GetUserDetailsByIdAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public async Task<ResultArgs> UpdateUserDetailsAsync(ProductDetailDTO productDetail)
		{
			ResultArgs ResultArgs = new ResultArgs();
			try
			{
				int objUserDetail = await _productRepository.UpdateUserDetailsAsync(productDetail);
				if (objUserDetail == 0)
				{
					ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
					ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.SaveSuccess;

				}
				else
				{
					ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Failed;
					ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.SaveFailed;
				}
			}
			catch (Exception ex)
			{

			}
			return ResultArgs;
		}
	}
}
