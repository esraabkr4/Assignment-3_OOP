using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP
{
    internal class Circle : ICircle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This shape is circle ,it ia area is {Area}");
        }
    }
}
