using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Interface
{
	public interface IpaymentRepository
	{
		Task<PaymentDetailResults> GetUserDetailsAsync();

		Task<int> AddUserDetailsAsync(PamentDetailDTO userDetailDTO);

	}
}
