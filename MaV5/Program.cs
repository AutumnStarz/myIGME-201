using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z= 0;

            double[,,] values = new double[x, y, z];
            while (x >= -1 && x <= 1 &&  y >= -1 && y <= 4)
            {
                z = (3 * (y * y)) + (2 * x) - 1; 
            }

        }
    }
}
