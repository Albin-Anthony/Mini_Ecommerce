using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using Mini_Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Repository
{
	public class PaymentRepository : IpaymentRepository
	{
		public Task<int> AddUserDetailsAsync(PamentDetailDTO userDetailDTO)
		{
			throw new NotImplementedException();
		}

		public Task<PaymentDetailResults> GetpaymentDetailsAsync()
		{
			throw new NotImplementedException();
		}
	}
}
