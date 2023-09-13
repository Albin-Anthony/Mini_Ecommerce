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
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly IDapperHandler _DapHandler;

        public UserDetailsRepository(IDapperHandler dapperHandler)
        {
            _DapHandler = dapperHandler;

        }

        //public async Task<UserDetailDTO> RepoGetUserDetailsByIdAsync(int Id)
        //{

        //    UserDetailDTO userDetail = new UserDetailDTO();
        //    try
        //    {
        //        DynamicParameters dynamicParameters = new DynamicParameters();
        //        dynamicParameters.Add(DBParameter.UserDetails.UserId, Id, DbType.Int16);

        //        using (_DapHandler.Connection)
        //        {
        //            userDetail = (await _DapHandler.QuerySingleAsync<UserDetailDTO>(StroredProc.UserDetails.SelectUserById, dynamicParameters));
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return userDetail;
        //}
        public async Task<UserDetailDTO> RepoGetUserDetailsByIdAsync(int Id)
        {
            UserDetailDTO  userDetail = new UserDetailDTO();

            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();

                dynamicParameters.Add(DBParameter.UserDetails.UserId, Id, DbType.Int32);



                userDetail = (await _DapHandler.QuerySingleAsync<UserDetailDTO>(StroredProc.UserDetails.SelectUserById, dynamicParameters));

            }
            catch (Exception)
            {

            }
            return userDetail;
        }

        public async Task<int> RepoInsertDetailsAsync(UserDetailDTO user)
        {
            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.UserDetails.UserId, user.UserId, DbType.Int16);
                    dynamicParameters.Add(DBParameter.UserDetails.UserName, user.UserName, DbType.String);
                    dynamicParameters.Add(DBParameter.UserDetails.Email, user.Email, DbType.String);
                    dynamicParameters.Add(DBParameter.UserDetails.FirstName, user.FirstName, DbType.String);
                    dynamicParameters.Add(DBParameter.UserDetails.LastName, user.LastName, DbType.String);
                    dynamicParameters.Add(DBParameter.UserDetails.DOB, user.DOB, DbType.DateTime);
                    dynamicParameters.Add(DBParameter.UserDetails.ImageURL, user.ImageURL, DbType.String);
                    dynamicParameters.Add(DBParameter.UserDetails.Address, user.Address, DbType.String);
                    response = await _DapHandler.ExecuteScalarAsync<int>(StroredProc.UserDetails.InsertUser, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }
    }
}
