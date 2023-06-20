using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace slnEFCoreDatabaseFirst_StoreProcedure.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


}
