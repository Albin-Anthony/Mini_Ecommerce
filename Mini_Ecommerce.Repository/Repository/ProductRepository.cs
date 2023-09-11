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

		public async Task<ProductDetailResults> GetUserDetailsAsync()
		{
			ProductDetailResults userDetailResult = new ProductDetailResults();
			try
			{

				userDetailResult.UserDetailsList = (await _dapperHandler.QueryAsync<ProductDetailDTO>(StroredProc.Product.SelectProduct)).ToList();
			}
			catch (Exception ex)
			{

			}
			return userDetailResult;
		}

		public Task<ProductDetailDTO> GetUserDetailsByIdAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public async Task<int> UpdateUserDetailsAsync(ProductDetailDTO ProductDetailDTO)
		{
			var parameters = new DynamicParameters();
			Int16 ReturnValue = 0;
			try
			{
				parameters.Add(DBParameter.product.ProductId, ProductDetailDTO.ProductId, DbType.Int32);
				parameters.Add(DBParameter.product.Name, ProductDetailDTO.Name, DbType.Int32);
				parameters.Add(DBParameter.product.Brand, ProductDetailDTO.Brand, DbType.String);
				parameters.Add(DBParameter.product.Model, ProductDetailDTO.Model, DbType.DateTime);
				parameters.Add(DBParameter.product.ImageURL, ProductDetailDTO.ImageURL, DbType.Int32);
				parameters.Add(DBParameter.product.Category, ProductDetailDTO.Category, DbType.Int32);
				parameters.Add(DBParameter.product.Price, ProductDetailDTO.Price, DbType.Int32);

				ReturnValue = await _dapperHandler.ExecuteScalarAsync<Int16>(StroredProc.Product.updateProduct, parameters);
			}
			catch (Exception ex)
			{

			}

			return ReturnValue;
		}
	}
}
