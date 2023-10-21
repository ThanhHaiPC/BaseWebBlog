using BaseProject.Data.Entities;
using BaseProject.ViewModel.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Catalog.Category
{
    public interface ICategoryService
    {
        Task<int> Create(CategoryRequest request);
        Task<int> Update(int categoriesId,CategoryRequest request);
        Task<int> Delete(int id);
        Task<List<Categories>> GetAll();
    }
}
