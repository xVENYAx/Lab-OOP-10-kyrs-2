using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_10_kyrs_2
{
    class Trail : Pass_point
    {
        private int point = 80;
        private string name;
        private double number;

        public Trail()
        {
            name = "Вид";
            number = 0;
        }
        public Trail(string name, double number)
        {
            this.name = name;
            this.number = number;
        }
        public string Name { get => name; set => name = value; }
        public double Number { get => number; set => number = value; }

        public virtual void Print()
        {
            Console.WriteLine("Значение полей");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Number = {number}");
        }
        public virtual void Clear()
        {
            Console.WriteLine("Product.Clear");
        }

        public override int GetPass_point()
        {
            return point;

        }

        public override void SetPass_point(int point)
        {
            this.point = point;
        }
    }
}
