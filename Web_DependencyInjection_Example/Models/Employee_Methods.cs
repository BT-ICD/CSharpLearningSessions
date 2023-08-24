using Newtonsoft.Json;

namespace Web_DependencyInjection_Example.Models
{

    public partial class Employee
    {
        public int Commission { 
            get{
                return Salary * 10 / 100;
            } 
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
