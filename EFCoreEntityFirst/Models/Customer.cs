﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEntityFirst.Models
{
    internal class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
