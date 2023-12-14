using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunction
{
    internal class Program
    {
        public delegate double MyRounder(double d, int n);
        static void Main(string[] args)
        {
            // create variable of delegate function type 
            MyRounder myRounder;

            // your code here

            //1
            myRounder = (double d, int n) => Math.Round(d, n);

            //2
            myRounder = (d,n) => Math.Round(d, n);

            //3
            myRounder = (double d, int n) =>
            {
                return Math.Round(d, n);
            };

            //4
            myRounder = Math.Round;

            //5 (using created method)
            myRounder = Rounder;



        }

        static double Rounder(double d, int n)
        {
            return Math.Round(d, n);
        }
    }


    }

