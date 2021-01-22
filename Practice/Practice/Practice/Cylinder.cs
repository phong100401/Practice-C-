using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Cylinder
    {
         public double radius;
         public double height;
         public double baseArea;
         public double lateralArea;
         public double totalArea;
         public double volume;

        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            height = Convert.ToDouble(Console.ReadLine());
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
           
        }
        public void Result()
        {
            
            Console.WriteLine("Cylinder Characterist");
            Console.WriteLine("Radius: {0},Height: {1}", radius, height);
            Console.Write("Base: {0:0.00} | Lateral: {1:0.00} | Total: {2:0.00} | Volume: {3:0.00}", baseArea,lateralArea,totalArea,volume);
            
        }
                static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            c1.Process();
            c1.Result();
            Console.ReadKey();
        }
    }
}
