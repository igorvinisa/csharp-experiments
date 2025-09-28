using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization; 
using System.Threading.Tasks;

namespace RectangleMeasurements
{
    public class Rectangle
    {
        public double Base;

        public double Height;

        public double Area()
        {
            return Base * Height;
        }   

        public double Perimeter()
        {
            return 2 * (Base + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Base * Base + Height * Height);
        }   

        public override string ToString()
        {
            return $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}, Perimeter: {Perimeter().ToString("F2", CultureInfo.InvariantCulture)}, Diagonal: {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
