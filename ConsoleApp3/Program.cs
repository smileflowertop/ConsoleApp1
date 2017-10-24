using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(105);
            Console.Write(stu.Age);
            stu.Age = 100;
            Console.Write(stu.Age);
        }
    }
    class Student
    {
        private int _age = 10;
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this._age = value;
                }
            }
        }
        public Student(int age)
        {
            this._age = age;
        }
    }
}
