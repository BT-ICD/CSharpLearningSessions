using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Repository
{
    public interface IDept
    {
        List<Dept> GetList();
    }
}
