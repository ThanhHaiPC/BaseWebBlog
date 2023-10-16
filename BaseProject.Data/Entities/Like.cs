﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Entities
{
    public class Like
    {
        public int LikeID { get; set; }
        public int PostID { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }



        // Relationship
        public Posts Post { get; set; }
        public User User { get; set; }
    }
}
