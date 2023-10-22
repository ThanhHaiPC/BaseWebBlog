using BaseProject.Data.EF;
using BaseProject.Data.Entities;
using BaseProject.ViewModel.Catalog.Authors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Catalog.Authors
{
    public class AuthorService : IAuthorService
    {
        private readonly BlogDbContext _context;
        public async Task<int> Create(AuthorRequest request)
        {
            if(request.Name == null)
            {
                throw new Exception("Tên tác giả trống");
            }
            var author = await _context.Authors.Where(x=>x.Name == request.Name).ToListAsync();
            if(author.Count != 0 )
            {
                throw new Exception("Tác gỉa này đã tồn tại");
            }
            var add = new Author
            {
                Name = request.Name
            };
            _context.Authors.Add(add);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(x=>x.AuthorID == id);
            _context.Authors.Remove(author);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Author>> GetAll()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<int> Update(int id, AuthorRequest request)
        {
            var author = await _context.Authors.FirstOrDefaultAsync(x=>x.AuthorID == id);
            request.Name = author.Name;
            _context.Authors.Update(author);
            return await _context.SaveChangesAsync();
        }
    }
}
