using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FreightTrain train = new FreightTrain();
            //AddPassenger(train);
        }
        static void AddPassenger(IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());

        }
    }
}
