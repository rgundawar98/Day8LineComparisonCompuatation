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
            double lengthx=0 ,lengthy=0, LineLength = 0;
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
        }
    }
}
