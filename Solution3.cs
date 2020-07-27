using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousantAssessment
{
    public class Solution3
    {
        public void DrawRectangle(int lenght, int width)
        {

            for (int i = 1; i <= lenght; i++)

            {

                for (int j = 1; j <= width; j++)

                {

                    if (i == 1 || i == lenght)
                    {
                        Console.Write("*"); //prints at border place
                    }
                    else if (j == 1 || j == width)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write(" "); //prints inside other than border
                    }
                }

                Console.WriteLine();

            }

        }
    }
}
