using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Repository.Interface;
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
		private readonly IpaymentRepository _userDetailRepository;

        public PaymentService(IpaymentRepository userDetailRepository)
        {
			_userDetailRepository = userDetailRepository;

		}
        public async Task<ResultArgs> AddUserDetailsAsync(PamentDetailDTO userDetailDTO)
		{
			var RresultArgs = new ResultArgs();

			var ResponseId = await _userDetailRepository.AddUserDetailsAsync(userDetailDTO);
			if (ResponseId == MessageCatlog.ErrorCodes.Success)
			{
				RresultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
				RresultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
			}
			else if (ResponseId == MessageCatlog.ErrorCodes.AlreadyExist)
			{ 
				RresultArgs.StatusCode = MessageCatlog.ErrorCodes.AlreadyExist;
				RresultArgs.StatusMessage = MessageCatlog.ErrorMessages.Exist;
			}
			else
			{
				RresultArgs.StatusCode = MessageCatlog.ErrorCodes.Failed;
				RresultArgs.StatusMessage = MessageCatlog.ErrorMessages.Failed;
			}

			return RresultArgs;
		}

		public Task<ResultArgs> GetUserDetailsAsync()
		{
			throw new NotImplementedException();
		}
	}
}
