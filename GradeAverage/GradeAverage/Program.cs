using Duplicates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeAverage gradeAverage = new GradeAverage();
            gradeAverage.DisplayResults();
            Console.WriteLine("\n ================================");
            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            removeDuplicate.DisplayResults();
            Console.ReadLine();
        }
    }
}
