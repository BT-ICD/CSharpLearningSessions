using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo1.Models
{
    public class Dept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public decimal Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
    }
}
