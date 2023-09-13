using Mini_Ecommerce.Models.Input;
using Mini_Ecommerce.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<CategoryResult> GetCategoryDetailsAsync();
        
        Task<int> SaveCategoryDetailsAsync(CategoryDTO category);
        Task<int> DeleteCategoryDetailsByIdAsync(int Id);
    }
}
