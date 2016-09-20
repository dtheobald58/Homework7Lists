using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool word in boolList)
            {
                if (word == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }

            }
        }
    }
}
