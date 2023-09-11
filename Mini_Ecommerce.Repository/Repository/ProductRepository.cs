using Dapper;
using Microsoft.Extensions.Configuration;
using Mini_Ecommerce.DBEngine;
using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using Mini_Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Repository
{
	public class ProductRepository : IProductRepository
	{
		private readonly IDapperHandler _dapperHandler;

        public ProductRepository(IDapperHandler dapperHandler)
        {
			_dapperHandler = dapperHandler;

		}
        public async Task<int> AddUserDetailsAsync(ProductDetailDTO ProductDetailDTO)
		{
			var parameters = new DynamicParameters();
			Int16 ReturnValue = 0;
			try
			{
				parameters.Add(DBParameter.product.Name, ProductDetailDTO.Name, DbType.String);
				parameters.Add(DBParameter.product.Brand, ProductDetailDTO.Brand, DbType.String);
				parameters.Add(DBParameter.product.Model, ProductDetailDTO.Model, DbType.String);
				parameters.Add(DBParameter.product.ImageURL, ProductDetailDTO.ImageURL, DbType.String);
				parameters.Add(DBParameter.product.Category, ProductDetailDTO.Category, DbType.String);
				parameters.Add(DBParameter.product.Price, ProductDetailDTO .Price, DbType.String);


				ReturnValue = await _dapperHandler.ExecuteScalarAsync<Int16>(StroredProc.Product.InsertProduct, parameters);
			}
			catch (Exception ex)
			{

			}

			return ReturnValue;
		}

		public Task<int> DeleteUserDetailsAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<ProductDetailResults> GetUserDetailsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<ProductDetailDTO> GetUserDetailsByIdAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<int> UpdateUserDetailsAsync(ProductDetailDTO userDetailDTO)
		{
			throw new NotImplementedException();
		}
	}
}
