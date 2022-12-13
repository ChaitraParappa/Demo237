using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {
        public static void FlipTheCoin()
        {
            int tailcount = 0;
            int headcount = 0;

            Console.WriteLine("Please enter the value for number of flips");

            int flip = Convert.ToInt32(Console.ReadLine());

            if(flip>0)
            {
               for(int i=0;i< flip; i++)
                {
                    Random random = new Random();

                    int number = random.Next(2);

                    Console.WriteLine(number);

                    if(number==0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }

                Console.WriteLine("HeadCount is " + headcount);
                Console.WriteLine("TailCount is " + tailcount);

                int headpercentage = headcount * 100 / flip;

                int tailpercentage = tailcount * 100 / flip;

                Console.WriteLine("Tail Percentage is " + tailpercentage+"%");
                Console.WriteLine("Head Percentage is " + headpercentage+"%");


            }
            else
            {
                Console.WriteLine("Please enter correct value");
            }
        }
    }
}
