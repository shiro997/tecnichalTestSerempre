using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Kpi Kpi { get; set; }

        public override string ToString() 
        {
            return $"Id:{Id}\nName:{Name}\nKpi:{Kpi}";
        }
    }
}
