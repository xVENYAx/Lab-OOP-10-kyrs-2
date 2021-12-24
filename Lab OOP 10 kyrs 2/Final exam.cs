using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_10_kyrs_2
{
    class Final_exam:Exam
    {
        private string instructor;
        private string availability_of_inspection;
        private string done;

        public Final_exam(string name, double number, string data, string time, double audience, string instructor, string availability_of_inspection, string done) : base(name, number, data, time, audience)
        {
            this.Name = name;
            this.Number = number;
            this.Data = data;
            this.Time = time;
            this.Audience = audience;
            this.Instructor = instructor;
            this.Availability_of_inspection = availability_of_inspection;
            this.Done = done;
        }
        
        public string Done { get => done; set => done = value; }
        public string Instructor { get => instructor; set => instructor = value; }
        public string Availability_of_inspection { get => availability_of_inspection; set => availability_of_inspection = value; }
        public override void Print()
        {
            Console.WriteLine("Final_Exam.Print");
            base.Print();
            Console.WriteLine($"Instructor = {instructor}");
            Console.WriteLine($"Availability of inspection = {availability_of_inspection}");
            Console.WriteLine($"Done = {done}");
        }
        public override void Clear()
        {
            Console.WriteLine("Final_Exam.Clear");
        }
    }
}
