using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Entities
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }

        //Relationship

        public List<Posts> Posts { get; set; }
    }
}
