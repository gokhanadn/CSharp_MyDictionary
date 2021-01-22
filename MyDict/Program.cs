using System;
using System.Collections.Generic;

namespace MyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
            MyDictionary<string, string> EmployeeList2 = new MyDictionary<string, string>();
            EmployeeList2.Add("Mahesh Chand", "Programmer");
            EmployeeList2.Add("Mahesh Chand", "Programmer");
            EmployeeList2.Add("Mahesh Chand", "Programmer");
            EmployeeList2.Add("Mahesh Chand", "Programmer");
            EmployeeList2.Add("Mahesh Chand", "Programmer");

            Console.WriteLine(EmployeeList2.Count);

        }
    }
}
