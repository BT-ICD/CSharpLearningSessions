using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Data;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Repository
{
    public class DeptRepo: IDept
    {
        private readonly LearningDbContext learningDbContext;

        public DeptRepo(LearningDbContext learningDbContext)
        {
            this.learningDbContext = learningDbContext;
        }

        public List<Dept> GetList()
        {
            var result = learningDbContext.Depts.ToList();
            return result;
        } 
    }
}
