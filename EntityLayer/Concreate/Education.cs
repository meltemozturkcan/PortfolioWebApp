﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Concreate
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }

        public int ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

