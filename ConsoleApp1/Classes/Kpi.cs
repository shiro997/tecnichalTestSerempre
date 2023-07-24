using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Kpi
    {
        public int Speed { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return "{\nSpeed:" + Speed + "\nLevel:" + Level + "\n}";
        }
    }
}
