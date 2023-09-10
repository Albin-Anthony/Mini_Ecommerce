using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Interface
{
	public interface IpaymentService
	{
		Task<ResultArgs> AddpaymentDetailsAsync(PamentDetailDTO userDetailDTO);

		Task<ResultArgs> GetpaymentDetailsAsync();

	}
}
