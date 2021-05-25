﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Product
    {
        public int Id { get; set; }



        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
