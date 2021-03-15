using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Test
    { 
       void test()
        {

        }
       public void test1()
        {
            Console.WriteLine("Hello");
        }
    }
    public class Employee
    {
        public string frist_name { get; set; }
        public string Last_name  { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        List<string> employeeNameList { get; set; }

    }
}
