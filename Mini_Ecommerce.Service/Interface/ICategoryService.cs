﻿using Mini_Ecommerce.Models;
using Mini_Ecommerce.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Service.Interface
{
    public interface ICategoryService
    {
        Task<ResultArgs> GetCategoryDetailsAsync();
        Task<ResultArgs> AddCategoryDetailsAsync(CategoryDTO CategoryDetail);
        Task<ResultArgs> DeleteCategoryDetailsByIdAsync(int id);

    }
}
