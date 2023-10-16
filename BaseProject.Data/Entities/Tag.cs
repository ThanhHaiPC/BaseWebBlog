﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Entities
{
    public class Tag
    {
        public int TagID { get; set; }
        public string TagName { get; set; }
        public int PostID { get; set; }


        // RelationShip
        public Posts Post { get; set; }
    }
}
