using BaseProject.Data.EF;
using BaseProject.Data.Entities;
using BaseProject.ViewModel.Catalog.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Catalog.Category
{
    public class CategoryService : ICategoryService
    { private readonly BlogDbContext _context;
        public async Task<int> Create(CategoryRequest request)
        {
            if(request.Name == null)
            {
                throw new Exception("Tên danh mục trống");
            }
            var category = await _context.Categories.Where(c => c.Name == request.Name).ToListAsync();
            if(category != null)
            {
                throw new Exception("Dang mục đã tồn tại");
            }
            var add = new Categories()
            {
                Name = request.Name
            };
            _context.Categories.Add(add);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x=>x.CategoriesID == id);
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Categories>> GetAll()
        {
            return await _context.Categories.ToListAsync();

        }

        public async Task<int> Update(int categoriesId, CategoryRequest request)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x=>x.CategoriesID == categoriesId);
            category.Name = request.Name;
            _context.Categories.Update(category);
            return await _context.SaveChangesAsync();
        }
    }
}
