using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PhonesUT2
{
    //Create PhoneInterface
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }
    //Create abstract class phone
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }
        public abstract void Connect();
        public abstract void Disconnect();
    }

    //create class RotaryPhone
    //Inhertits from Phone class and the interface
    public class RotaryPhone : Phone, PhoneInterface 
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }
    }

    //create class PushButtonPhone
    //Inhertits from Phone class and the interface
    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer() { }
        public void MakeCall() { }
        public void HangUp() { }
        public override void Connect() { }
        public override void Disconnect() { }

    }

    //create Tardis class
    //Inherits from Rotary Phone
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        //compare and overload 
        public int compareObj(Tardis obj) {
            if (obj == null)
            {
                return 1;
            }
            if (whichDrWho == 10 && obj.whichDrWho != 10)
            {
                return 1;
            }
            else if(whichDrWho != 10 && obj.whichDrWho == 10)
            {
                return 0;
            }
            else
            {
                return whichDrWho.CompareTo(obj.whichDrWho);
            }



        }
        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }

        public void TimeTravel() { }
    }
    //create phonebooth class
    //inherits from PushButtonPhone
    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() { }
        public void CloseDoor() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create both a tardis and phonebooth obj
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();
            //cal the UsePhone method on them
            UsePhone(tardis);
            UsePhone(phoneBooth);


            
        }

        //create UsePhone method
        static void UsePhone(object obj)
        {
            //check if the object is a

            if (obj is PhoneInterface phoneInterface)
            {
                phoneInterface.MakeCall();
                phoneInterface.HangUp();
            }

            if (obj is PhoneBooth phoneBooth)
            {
                phoneBooth.OpenDoor();
            }

            if(obj is Tardis tardis)
            {
                tardis.TimeTravel();
            }
        }
    }
}
