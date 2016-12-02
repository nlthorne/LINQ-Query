using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    public class RemoveDuplicate
    {
        private List<string> listOfStrings;

        public RemoveDuplicate()
        {
            listOfStrings = new List<string>() { "Hello", "Test", "Hello", "World", "!!!", "!!!", "Test" };
        }

        public void DisplayResults()
        {
            
            Console.Write("Original list: ");
            foreach (string value in listOfStrings)
            {
                Console.Write($"{value} ");
            }

            Console.Write("\nNew list without duplicates: ");
            var result = listOfStrings.Distinct();
            foreach (string value in result)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine("\n");
        }
    }
}
