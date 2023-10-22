using BaseProject.Data.Entities;
using BaseProject.ViewModel.Catalog.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Catalog.Authors
{
    public interface IAuthorService
    {
        Task<int> Create( AuthorRequest request);
        Task<int> Update( int id,AuthorRequest request );
        Task<int> Delete( int id );
        //Task<AuthorRequest> GetById( int id );
        Task<List<Author>> GetAll();
    }
}
