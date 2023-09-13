using Dapper;
using Mini_Ecommerce.DBEngine;
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
    public class CategoryRepository : ICategoryRepository
    {
       // private readonly ISQLServerHandler _serverHandler;

        private readonly IDapperHandler _dapperHandler;

        public CategoryRepository(IDapperHandler dapperHandler) {

             _dapperHandler = dapperHandler;
        }
        //public CategoryRepository(ISQLServerHandler serverHandler)
        //{
        //    this._serverHandler = serverHandler;
        //}

        

        public async Task<int> DeleteCategoryDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@Categoryid", Id, DbType.Int32);

                response = await _dapperHandler.ExecuteScalarAsync<int>("[dbo].[DeleteCategory]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<CategoryResult> GetCategoryDetailsAsync()
        {
            CategoryResult CategoryDetailResult = new CategoryResult();
            try
            {
                
              CategoryDetailResult.CategoryDetail = (await _dapperHandler.QueryAsync<CategoryDTO>("[dbo].[GetCategory]")).ToList();
                
            }
            catch (Exception ex)
            {
            }
            return CategoryDetailResult;
        }
        public async Task<int> SaveCategoryDetailsAsync(CategoryDTO category)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@CategoryId", category.CategoryId, DbType.Int32);
                dynamicParameters.Add("@CategoryName", category.CategoryName, DbType.String);
                dynamicParameters.Add("@CategoryDescription", category.CategoryDescription, DbType.String);



                response = await _dapperHandler.ExecuteScalarAsync<int>("[dbo].[SaveOrUpdateCategory]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
