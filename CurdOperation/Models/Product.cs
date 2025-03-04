﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CurdOperation.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CreatedDate { get; set; }

        [Display(Name = "CategoryID")]
        public virtual int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
