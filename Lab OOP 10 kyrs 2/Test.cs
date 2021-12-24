using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_10_kyrs_2
{

    class Test:Trail
    {
        public string rating;
        public Test(string name, double number, string rating) : base(name, number)
        {
            this.Name = name;
            this.Number = number;
            this.Rating = rating;
        }
        public string Rating { get => rating; set => rating = value; }

        public override void Print()
        {
            Console.WriteLine("Test.Print");
            base.Print();
            Console.WriteLine($"Rating = {rating}");
        }
        public override void Clear()
        {
            Console.WriteLine("Test.Clear");
        }
    }
}
