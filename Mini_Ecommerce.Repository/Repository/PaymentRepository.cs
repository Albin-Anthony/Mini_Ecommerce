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
	public class PaymentRepository : IpaymentRepository
	{
		private readonly IDapperHandler _configuration;

        public PaymentRepository(IDapperHandler configuration)
        {
			_configuration = configuration;

		}
        public async Task<int> AddUserDetailsAsync(PamentDetailDTO userDetailDTO)
		{
			var parameters = new DynamicParameters();
			Int16 ReturnValue = 0;
			try
			{
				parameters.Add(DBParameter.payment.CardNumber, userDetailDTO.CardNumber, DbType.Int32);
				parameters.Add(DBParameter.payment.NameOnCard, userDetailDTO.NameOnCard, DbType.String);
				parameters.Add(DBParameter.payment.ExpiryDate, userDetailDTO.ExpiryDate, DbType.DateTime);
				parameters.Add(DBParameter.payment.CVVCode, userDetailDTO.CVVCode, DbType.Int32);

				ReturnValue = await _configuration.ExecuteScalarAsync<Int16>(StroredProc.Payment.InsertPayment, parameters);
			}
			catch (Exception ex)
			{

			}

			return ReturnValue;
		}

		public async Task<PaymentDetailResults> GetUserDetailsAsync()
		{
			PaymentDetailResults userDetailResult = new PaymentDetailResults();
			try
			{

				userDetailResult.UserDetailsList = (await _configuration.QueryAsync<PamentDetailDTO>(StroredProc.Payment.SelectPament)).ToList();
			}
			catch (Exception ex)
			{

			}
			return userDetailResult;
		}
	}
}
