using Mini_Ecommerce.Framework;
using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models;
using Mini_Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mini_Ecommerce.Service.Interface;
using Mini_Ecommerce.Models.Output;

namespace Mini_Ecommerce.Service.Service
{
    public class ShopCartsService : IShopCartsService
    {
        private readonly ICartsDetailsRepository _CartRepo;

        public ShopCartsService(ICartsDetailsRepository CartsRepo)
        {
            _CartRepo = CartsRepo;

        }
        public async Task<ResultArgs> SerGetAllCartDetailsAsync()
        {
            ResultArgs ResultArgs = new ResultArgs();
            try
            {
                var objCartDetail = await _CartRepo.RepoGetAllCartDetailsAsync();

                ResultArgs.MessageTitle = MessageCatlog.MessageTitle.CartDetails;

                if (objCartDetail != null)
                {
                    ResultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                    ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                    ResultArgs.ResultData = objCartDetail.CartDetailsList;
                }
                else
                {
                    ResultArgs.StatusCode = MessageCatlog.ErrorCodes.NoRecordFound;
                    ResultArgs.StatusMessage = MessageCatlog.ErrorMessages.NoRecordFound;
                }
            }
            catch (Exception)
            {

            }
            return ResultArgs;



        }
        
        public async Task<ResultArgs> SerGetCartDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            CartDetailDTO obj = await _CartRepo.RepoGetCartDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.CartDetails;
                resultArgs.ResultData = obj;


            }
            else
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }
        public async Task<ResultArgs> SerDeleteCartByIdAsync(Int64 Id)
        {

            ResultArgs resultArgs = new ResultArgs();

            int result = await _CartRepo.RepoDeleteCartDetailsByIdAsync(Id);
            if (result == 0)
            {

                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.CartDetails;
            }
            else
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.BadRequest;
            }
            return resultArgs;

        }
        public async Task<ResultArgs> SerInsertCartDetailsAsync(CartDetailDTO user)
        {

            ResultArgs resultArgs = new ResultArgs();

            int result = await _CartRepo.RepoInsertCartDetailsAsync(user);
            if (result == 0)
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.CartDetails;
            }
            else
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.BadRequest;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.BadRequest;
            }
            return resultArgs;
        }
        public async Task<ResultArgs> SerUpdateCartDetailsByIdAsync(CartDetailDTO cart)
        {

            ResultArgs resultArgs = new ResultArgs();

            int result = await _CartRepo.RepoUpdateCartDetailsByIdAsync(cart);
            if (result == 0)
            {
                resultArgs.StatusCode = MessageCatlog.ErrorCodes.Success;
                resultArgs.StatusMessage = MessageCatlog.ErrorMessages.Success;
                resultArgs.MessageTitle = MessageCatlog.MessageTitle.CartDetails;
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
