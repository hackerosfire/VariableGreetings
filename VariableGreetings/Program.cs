using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableGreetings
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputAge = double.Parse(Console.ReadLine());
            string inputGender = Console.ReadLine();
            if (inputGender == "f" && inputAge < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (inputGender == "f" && inputAge >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else if (inputGender == "m" && inputAge < 16)
            {
                Console.WriteLine("Master");
            }
            else
            {
                Console.WriteLine("Mr.");
            }
        }
    }
}