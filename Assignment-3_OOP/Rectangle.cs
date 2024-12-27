using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOP
{
    internal class Rectangle : IRectangle
    {
        public int Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This shape is Rectangle ,it ia area is {Area}");

        }
    }
}
