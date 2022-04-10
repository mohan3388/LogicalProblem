using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicsProblem
{
    public class PrimeFactor
    {

        int count = 0;
        public void primeFactor()
        {
            Console.WriteLine("Hello Sir Enter a number:->");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count <= 2)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
        }

    }
}