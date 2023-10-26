using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2yUML
{
    public interface IDrawDigital
    {
        void Draw();
    }

    public interface IDrawTraditional
    {
        void Draw();
    }
    public abstract class Art
    {
        public abstract void GetSupplies();
        public virtual void DrawSomething() { }
    }

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
            TraditionalArt art = new TraditionalArt();
            DigitalArt digitalArt = new DigitalArt();
        }

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
