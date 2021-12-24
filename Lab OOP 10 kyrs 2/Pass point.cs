using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_10_kyrs_2
{
    abstract class Pass_point
    {
        public abstract int GetPass_point();
        public abstract void SetPass_point(int point);
        public void MinPass_point()
        {
            Console.WriteLine("Мінімальний бал, для допуску до фінального екзамену ≥ 70");
        }
    }
}
