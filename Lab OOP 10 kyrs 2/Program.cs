using System;

namespace Lab_OOP_10_kyrs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Trail p1 = new Trail("Випробування", 3);
            Console.WriteLine("Класс Trial");
            p1.Print();
            p1.Clear();
            p1.GetPass_point();
            p1.MinPass_point();
            Console.WriteLine("--------------");
            
            Console.WriteLine("Класс Test");
            p1 = new Test("Тест", 2, "95/100");
            p1.Print();
            p1.Clear();
            Console.WriteLine("--------------");
            
            Console.WriteLine("Класс Exam");
            Exam b1 = new Exam("Іспит", 3, "10/10/20", "12:30", 415);
            b1.Start();
            b1.End();
            p1 = new Exam("Іспит", 3, "10/10/20", "12:30", 415);
            p1.Print();
            b1.ControlVisiting(true);
            p1.Clear();
            Console.WriteLine("--------------");
           
            Console.WriteLine("Класс Final_exam");
            p1 = new Final_exam("Випускний іспит", 1, "15/10/20", "15:30", 415, "Molotkov O. K.", "Yes", "Yes");
            p1.Print();
            p1.Clear();
            Console.WriteLine("--------------");
        }
    }
}