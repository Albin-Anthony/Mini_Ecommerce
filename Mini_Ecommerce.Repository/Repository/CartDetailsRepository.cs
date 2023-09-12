using Dapper;
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
    public class CartDetailsRepository : ICartsDetailsRepository
    {
        DapperHandler _DapHandler;
        public CartDetailsRepository(DapperHandler DapHandler)
        {
            _DapHandler = DapHandler;
        }
        public async Task<CartDetailResult> RepoGetAllCartDetailsAsync()
        {
            CartDetailResult carts = new CartDetailResult();
            try
            {

                carts.CartDetailsList = (await _DapHandler.QueryAsync<CartDetailDTO>(StroredProc.CartDetails.SelectAllCart)).ToList();
            }
            catch (Exception )
            {
                
            }
            return carts;
        }
        
        public async Task<CartDetailDTO> RepoGetCartDetailsByIdAsync(int Id)
        {

            CartDetailDTO cartDetail = new CartDetailDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(DBParameter.CartDetails.CartId, Id, DbType.Int16);

                using (_DapHandler.Connection)
                {
                    cartDetail = (await _DapHandler.QuerySingleAsync<CartDetailDTO>(StroredProc.CartDetails.SelectCartById, dynamicParameters));
                }
            }
            catch (Exception)
            {
            }
            return cartDetail;
        }
        public async Task<int> RepoInsertCartDetailsAsync(CartDetailDTO user)
        {
            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.CartDetails.CartId, user.CartId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.CartDetails.UserId, user.UserId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.CartDetails.CreationDate, user.CreationDate, DbType.DateTime);

                    response = await _DapHandler.ExecuteScalarAsync<int>(StroredProc.CartDetails.InsertCart, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }
        public async Task<int> RepoDeleteCartDetailsByIdAsync(Int64 Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();

                dynamicParameters.Add("DoctorId", Id, DbType.Int32);

                using (_DapHandler.Connection)
                {
                    response = await _DapHandler.ExecuteScalarAsync<int>(StroredProc.CartDetails.DeleteCart, dynamicParameters);
                }

            }
            catch (Exception)
            {

            }
            return response;
        }
        public async Task<int> RepoUpdateCartDetailsByIdAsync(CartDetailDTO user)
        {
            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.CartDetails.CartId, user.CartId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.CartDetails.UserId, user.UserId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.CartDetails.CreationDate, user.CreationDate, DbType.DateTime);

                    response = await _DapHandler.ExecuteScalarAsync<int>(StroredProc.CartDetails.UpdateCart, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }

        
    }
}
    
    
