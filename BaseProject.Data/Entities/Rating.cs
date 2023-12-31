﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Data.Entities
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int PostID { get; set; }
        public Guid UserId { get; set; }
        public int RatingValue { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }



        // Relationship
        public Posts Post { get; set; }
        public User User { get; set; }

    }
}
