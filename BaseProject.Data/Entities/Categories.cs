using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Entities
{
    public class Categories
    {
        public int CategoriesID { get; set; }
        public string Name { get; set; }
        // Relationship
        public List<CategoriesDetail>? CategoriesDetail { get; set; }
    }
}
