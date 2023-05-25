using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CustomEvent_UserDefineEvent_Demo1
{
    internal class Student
    {
        public event EventHandler SemesterChanged;

        public int RollNo { get; set; }
        public string FirstName { get; set; }
        private int _semester;
        public int Semester {
            get{
            return _semester;
            } 
            set
            {
                if (value >= 0)
                {
                    _semester = value;
                    SemesterChanged?.Invoke(this, EventArgs.Empty);
                }
            } 
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
