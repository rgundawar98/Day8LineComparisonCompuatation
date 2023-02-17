using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8LineComparisonComputation
{
    public class LineComparison
    {
        public void Check_Lines()
        { 
            double lengthx=0 ,lengthy=0, LineLength = 0 , lengthA=0 ,lengthB=0,LineLength1=0;
            Console.WriteLine("Enter the Cartesian points for valx1 and valx2");
            int valx1 = Convert.ToInt32(Console.ReadLine());
            int valx2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Cartesian points for valy1 and valy2");
            int valy1 = Convert.ToInt32(Console.ReadLine());
            int valy2 = Convert.ToInt32(Console.ReadLine());
            lengthx = Math.Pow(valx2- valx1, 2);
            lengthy = Math.Pow((valy2- valy1), 2);
            Console.WriteLine("The length of cartesian points length is lengthx:"+lengthx);
            Console.WriteLine("The length of cartesian points length is lengthy:" + lengthy);
            LineLength = Math.Sqrt(lengthx *lengthy);
            Console.WriteLine("The length of the line is:"+LineLength);

            Console.WriteLine("Enter the Cartesian points for valA1 and valA2");
            int valA1 = Convert.ToInt32(Console.ReadLine());
            int valA2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Cartesian points for valB1 and valB2");
            int valB1 = Convert.ToInt32(Console.ReadLine());
            int valB2 = Convert.ToInt32(Console.ReadLine());
            lengthA = Math.Pow(valA2 - valA1, 2);
            lengthB = Math.Pow((valB2 - valB1), 2);
            Console.WriteLine("The length of cartesian points length is lengthx:" + lengthA);
            Console.WriteLine("The length of cartesian points length is lengthy:" + lengthB);
            LineLength1 = Math.Sqrt(lengthA * lengthB);
            Console.WriteLine("The length of the line is:" + LineLength1);

            if(LineLength == LineLength1)
            {
                Console.WriteLine("Both lines are equal to each other");
            }
            else if(LineLength > LineLength1)
            {
                Console.WriteLine("First length is greater than second");
            }
            else
            {
                Console.WriteLine("Both lines are not similar");
            }
        }
    }
}
