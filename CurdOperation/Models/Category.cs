﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Models
{
    public class Category 
    { 
    
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CreatedDate { get; set; }
    }
}
