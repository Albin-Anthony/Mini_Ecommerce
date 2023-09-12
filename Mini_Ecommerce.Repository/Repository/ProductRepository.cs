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

		public async Task<int> DeleteUserDetailsAsync(int Id)
		{
			Int16 ReturnValue = 0;
			var parameters = new DynamicParameters();
			try
			{
				parameters.Add(DBParameter.product.ProductId, Id, DbType.Int32);
				ReturnValue = await _dapperHandler.ExecuteScalarAsync<Int16>(StroredProc.Product.deleteProduct, parameters);
			}
			catch (Exception ex)
			{

			}
			return ReturnValue;
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

		public async Task<ProductDetailDTO> GetUserDetailsByIdAsync(int Id)
		{
			ProductDetailDTO ProductDetail = new ProductDetailDTO();

			try
			{
				DynamicParameters dynamicParameters = new DynamicParameters();

				dynamicParameters.Add(DBParameter.product.ProductId, Id, DbType.Int32);



				ProductDetail = (await _dapperHandler.QuerySingleAsync<ProductDetailDTO>(StroredProc.Product.SelectById, dynamicParameters));

			}
			catch (Exception ex)
			{

			}
			return ProductDetail;
		}

		public async Task<int> UpdateUserDetailsAsync(ProductDetailDTO ProductDetailDTO)
		{
			var parameters = new DynamicParameters();
			Int16 ReturnValue = 0; 
			try
			{
				parameters.Add(DBParameter.product.ProductId, ProductDetailDTO.ProductId, DbType.Int32);
				parameters.Add(DBParameter.product.Name, ProductDetailDTO.Name, DbType.String);
				parameters.Add(DBParameter.product.Brand, ProductDetailDTO.Brand, DbType.String);
				parameters.Add(DBParameter.product.Model, ProductDetailDTO.Model, DbType.String);
				parameters.Add(DBParameter.product.ImageURL, ProductDetailDTO.ImageURL, DbType.String);
				parameters.Add(DBParameter.product.Category, ProductDetailDTO.Category, DbType.String);
				parameters.Add(DBParameter.product.Price, ProductDetailDTO.Price, DbType.String);

				ReturnValue = await _dapperHandler.ExecuteScalarAsync<Int16>(StroredProc.Product.updateProduct, parameters);
			}
			catch (Exception ex)
			{

			}

			return ReturnValue;
		}
	}
}
