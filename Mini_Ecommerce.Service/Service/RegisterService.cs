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
    public class RegisterService: IRegisterService
    {
        private readonly IRegisterRepositorycs _RegisterRepository;
        public RegisterService(IRegisterRepositorycs RegisterRepository)
        {
            _RegisterRepository = RegisterRepository;
        }

        public async Task<ResultArgs> SaveRegisterDetailsAsync(RegisterDTO registerDetails)
        {
            ResultArgs resultArgs = new ResultArgs();
            int result = (await _RegisterRepository.SaveRegisterDetailsAsync(registerDetails));
            if (result > 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.MessageTitle = "Save Success";

            }
            else
            {
                resultArgs.StatusCode = 204;
                resultArgs.MessageTitle = "Save Failed";
            }

            return resultArgs;
        }


        public async Task<ResultArgs> LoginDetailsAsync(LoginDTO Logindetail)
        {
            ResultArgs resultArgs = new ResultArgs();
            int result = (await _RegisterRepository.LoginDetailsAsync(Logindetail));
            if (result > 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.MessageTitle = "Login Successfully";

            }
            else
            {
                resultArgs.StatusCode = 204;
                resultArgs.MessageTitle = "Invalid credentials";
            }

            return resultArgs;
        }
    }
}
