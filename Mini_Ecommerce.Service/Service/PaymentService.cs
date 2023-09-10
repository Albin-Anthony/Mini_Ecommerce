using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Service
{
	public class PaymentService : IpaymentService
	{
		public Task<ResultArgs> AddpaymentDetailsAsync(PamentDetailDTO userDetailDTO)
		{
			throw new NotImplementedException();
		}

		public Task<ResultArgs> GetpaymentDetailsAsync()
		{
			throw new NotImplementedException();
		}
	}
}
