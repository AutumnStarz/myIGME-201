using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2yUML
{
    //create interfaces
    public interface IDrawDigital
    {
        void Draw();
    }

    public interface IDrawTraditional
    {
        void Draw();
    }

    //create abtract class with a virtual and void
    public abstract class Art
    {
        public abstract void GetSupplies();
        public virtual void DrawSomething() { }
    }

    //create children that inherit from abstract and interfce
    public class DigitalArt : Art, IDrawDigital
    {
        public string device;

        public override void GetSupplies() { }
        public void Draw() { }
    }

    public class TraditionalArt : Art, IDrawTraditional
    {
        public string device;

        public override void GetSupplies() { }
        public void Draw() { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects from the children classes
            TraditionalArt art = new TraditionalArt();
            DigitalArt digitalArt = new DigitalArt();

            //call them with the method
            MyMethod(art);
            MyMethod(digitalArt);
        }

        //method
        static void MyMethod(object obj)
        {
            if (obj is TraditionalArt traditional)
            {
                traditional.DrawSomething();    
            }
            if (obj is  DigitalArt digitalArt)
            {
                digitalArt.DrawSomething();
            }
        }
    }
}
