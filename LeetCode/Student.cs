using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Student
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Student() { }
        public void sayHello()
        {
            Console.WriteLine("hello World");
        }
        public void presentJob(string job)
        {
            Console.WriteLine("my name is "+this.Name+" I'm "+job);
        }
    }
}
