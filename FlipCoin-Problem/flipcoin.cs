using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipcoin
{
    public class Coin
    {
        const double IsHead = 0.5;
        int headCount = 0, tailCount=0, Headcoin_Percent=0, Tailcoin_Percent=0;

        public void Flipcoin()
        {
            Console.WriteLine("Enter number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i =0; i<num; i++)
            {
                Random random = new Random();
                int Check = random.Next(0,2);
                if(Check<IsHead)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            Console.WriteLine("Head coin " + headCount);
            Console.WriteLine("Tail coin " + tailCount);

            Headcoin_Percent = headCount * 100 / num;
            Tailcoin_Percent = 100 - Headcoin_Percent;

            Console.WriteLine("percentage of Headcoin: " + Headcoin_Percent);
            Console.WriteLine("percentage of Tailcoin: " + Tailcoin_Percent);
        }

    }
}
