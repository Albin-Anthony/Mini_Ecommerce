using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using Mini_Ecommerce.Repository.Interface;
using Mini_Ecommerce.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Service
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepository _UserRepo;

        public UserDetailsService(IUserDetailsRepository UserRepo)
        {
            _UserRepo = UserRepo;

        }
        public async Task<ResultArgs> SerGetUserDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            UserDetailDTO obj = await _UserRepo.RepoGetUserDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.UserDetails;
                resultArgs.ResultData = obj;


            }
            else
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }
        public async Task<ResultArgs> SerInsertUserDetailsAsync(UserDetailDTO user)
        {

            ResultArgs resultArgs = new ResultArgs();

            int result = await _UserRepo.RepoInsertDetailsAsync(user);
            if (result == 0)
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.UserDetails;
            }
            else
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }
    }
}
