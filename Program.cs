using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousantAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1 solution1 = new Solution1();
            Solution2 solution2 = new Solution2();
            Solution3 solution3 = new Solution3();
            Solution4 solution4 = new Solution4();

            Console.WriteLine("......................Number1.................");
            solution1.PrintCategories();
            Console.WriteLine();

            Console.WriteLine("......................Number2.................");
            solution2.Encrypt("Amos");
            Console.WriteLine();

            Console.WriteLine("......................Number3.................");
            solution3.DrawRectangle(6, 4);
            Console.WriteLine();

            Console.WriteLine("......................Number1e4.................");
            solution4.GetMondayNews();

            Console.ReadKey();

        }


    }
}
