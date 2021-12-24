using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_10_kyrs_2
{
    class Visiting
    {
        public Visiting() { }
        public void TheVisiting(bool Is)
        {
            if (Is)
            {
                Console.WriteLine("Прийшло на екзамен > 50% студентів");
            }
            else
            {
                Console.WriteLine("Прийшло на екзамен < 50% студентів");
            }
        }
    }

    class Exam:Trail, TExam
    {
        public void Start() { Console.WriteLine("Екзамен почався"); }
        public void End() { Console.WriteLine("Екзамен закінчився"); }
        private string time;
        private string data;
        private Visiting Visiting;
        
        public Exam()
        {
            data = "0";
            time = "11:15";
        }
        private double audience;
        public Exam(string name, double number, string data, string time, double audience) : base(name, number)
        {
            this.Name = name;
            this.Number = number;
            this.Data = data;
            this.Time = time;
            this.Audience = audience;
            Visiting = new Visiting();
        }

        public void ControlVisiting(bool State)
        {
            Visiting.TheVisiting(State);
        }

        public double Audience { get => audience; set => audience = value; }
        public string Time { get => time; set => time = value; }
        public string Data { get => data; set => data = value; }
        public override void Print()
        {
            Console.WriteLine("Exam.Print");
            base.Print();
            Console.WriteLine($"Data = {data}");
            Console.WriteLine($"Time = {time}");
            Console.WriteLine($"Audience = {audience}");
        }
        public override void Clear()
        {
            Console.WriteLine("Exam.Clear");
        }
    }
}
