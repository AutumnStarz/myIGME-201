﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IPassengerCarrier
    {
        void LoadPassenger();
        
    }
    public interface IHeavyLoadCarrier
    {

    }
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    public abstract class Car : Vehicle
    {

    }

    public abstract class Train : Vehicle
    {

    }

    public class Compact : Car, IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class I424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }


    public class Class1
    {
    }
}
