﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc
{
    internal class Product
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public float Price { get; set; }
    }
}
