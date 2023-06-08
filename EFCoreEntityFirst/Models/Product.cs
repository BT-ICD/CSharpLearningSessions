using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEntityFirst.Models
{
    internal class Product
    {
     
        public int Id { get; set; }
        public string Name { get; set; }
     
        public int Rate { get; set; }
    }
}
