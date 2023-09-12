using Dapper;
using Mini_Ecommerce.DBEngine;
using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Repository
{
    public class RegisterRepository: IRegisterRepositorycs
    {
        private readonly IDapperHandler _configuration;

        public RegisterRepository(IDapperHandler configuration)
        {
            _configuration = configuration;

        }
        public async Task<int> SaveRegisterDetailsAsync(RegisterDTO registerDetails)
        {
            int result = 0;
            var parameters = new DynamicParameters();
            try
            {
                parameters.Add(DBParameter.Register.CustomerId, registerDetails.CustomerId, DbType.Int32);
                parameters.Add(DBParameter.Register.FirstName, registerDetails.FirstName, DbType.String);
                parameters.Add(DBParameter.Register.LastName, registerDetails.LastName, DbType.String);
                parameters.Add(DBParameter.Register.PhoneNumber, registerDetails.PhoneNumber, DbType.Int64);
                parameters.Add(DBParameter.Register.Emailaddress, registerDetails.Emailaddress, DbType.String);
                parameters.Add(DBParameter.Register.Password, registerDetails.Password, DbType.String);


                result = (await _configuration.ExecuteScalarAsync<int>(StroredProc.Register.SaveRegister, parameters, CommandType.StoredProcedure));
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }
}
