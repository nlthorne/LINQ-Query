using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    class Function
    {

        public Function()
        {

        }
        
        public void GetAverage()
        {
            string grades = "90,100,82,89,55";
            var numbers = grades.Split(',').Select(Int32.Parse).ToList();
            numbers.Sort();
            double result = (from x in numbers where x > numbers[2] select x).Average();
            Console.WriteLine(result);
        }
    }
}
