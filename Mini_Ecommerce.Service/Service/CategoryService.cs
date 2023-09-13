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
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _CategoryDetailsRepository;

        public CategoryService(ICategoryRepository CategoryDetails)
        {
            this._CategoryDetailsRepository = CategoryDetails;
        }

        public async Task<ResultArgs> GetCategoryDetailsAsync()
        {
            ResultArgs resultArgs = new ResultArgs();

            CategoryResult obj = await _CategoryDetailsRepository.GetCategoryDetailsAsync();
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.CategoryDetailList;

            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }
        //public async Task<ResultArgs> AddCategoryDetailsAsync(CategoryDTO category)
        //{
        //    ResultArgs resultArgs = new ResultArgs();

        //    int result = await _CategoryDetailsRepository.AddCategoryDetailsAsync(category);
        //    if (result == 0)
        //    {
        //        resultArgs.StatusCode = 200;
        //        resultArgs.StatusMessage = "Record Save Successfully";
        //    }
        //    else
        //    {
        //        resultArgs.StatusCode = 200;
        //        resultArgs.StatusMessage = "Unable to Save records";
        //    }
        //    return resultArgs;
        //}

        public async Task<ResultArgs> SaveCategoryDetailsAsync(CategoryDTO category)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _CategoryDetailsRepository.SaveCategoryDetailsAsync(category);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Save Successfully";
            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }
        public async Task<ResultArgs> DeleteCategoryDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _CategoryDetailsRepository.DeleteCategoryDetailsByIdAsync(Id);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Deleted Successfully";

            }
            else
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;

        }

        public Task<ResultArgs> AddCategoryDetailsAsync(CategoryDTO CategoryDetail)
        {
            throw new NotImplementedException();
        }
    }
}
