using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public string name;
        public int weight;

        public virtual void Show()
        {

        }

        public virtual void SetMe(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
    class Lion : Animal
    {
        public override void SetMe(string name, int weight)
        {
            base.SetMe(name, weight);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Name: {0}, Weight: {1}", name, weight);
        }
    }
    class Tiger : Animal
    {
        public override void SetMe(string name, int weight)
        {
            base.SetMe(name, weight);
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Name: {0}, Weight: {1}", name, weight);
        }
    }
}

