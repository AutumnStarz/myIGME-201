using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IDrawObject //interface for shared things in classes
    {
        void DrawMe(); //shape class inhertits from the interface
    }

    public class Blood : IDrawObject 
    {
        public virtual void DrawMe() 
        {
        }
    }
    public abstract class Shape : IDrawObject //+A:Shape inherits from the interface, you can inherit from as many interfaces as you want
    {
        //code block for our class
        public const double PI = Math.PI; //public const var
        protected double x; //only accessable in the parent and child classes (protected)
        protected double y;

        private int myInt; //ONLY availiable in this code block (private)

        public virtual double Area()
        {
            return this.x * this.y;
        }

        public abstract void DrawMe(); //abstract, any child class must implement this method

        public Shape() //constructors, no return type
        {

        }
        public Shape (double x, double y) //constructors, no return type
        {
            this.x = x; //this.x refers to the field memeber x (protected double x)
            this.y = y;
        }
    }
    public sealed class Circle : Shape //child class of shape, limited to 1 parent //sealed classes can't be inherited (same for static)
    {
        public int myInt;
        public override double Area() //override the parent method
        {
            return Shape.PI * this.x * this.x; //this can not be used for constants, instead the class must be called
        }

        public override void DrawMe()
        {
            //code that specifically draws a circle
        }
        public Circle(double r) : base(r,0) //base constructor (double x, doubke y)
        {

        }
    }

    public class Sphere : Shape
    {
        public override double Area() //override the parent method
        {
            return 4* PI * this.x * this.x;
        }

        public override void DrawMe()
        {
            //code that specifically draws a sphere
        }
        public Sphere(double r) : base(r, 0) //base constructor (double x, doubke y)
        {

        }
    }

    internal class Cylinder : Shape
    {
        public override double Area() //override the parent method
        {
            return 2 * PI * this.x * this.x + 2 * PI * this.x * this.x;
        }

        public override void DrawMe()
        {
            //code that specifically draws a cylinder
        }
        public Cylinder(double r, double h) : base(r, h) //base constructor (double x, doubke y)
        {

        }
    }

    internal class Rectangle : Shape
    {
        public bool IsSquare //red only property
        {
            get
            {
                if(x == y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void DrawMe()
        {
            //code that specifically draws a rectangle
        }
        public Rectangle(double w, double h) : base(w, h) //base constructor (double x, doubke y)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MyMethod(); //needs to be accessed through a Program class

            //create some objects from our classes
            //four vars and four objects
            Circle circle = new Circle(5.5);
            Cylinder cylinder = new Cylinder(3, 6);
            Rectangle rectangle = new Rectangle(1, 2);
            Blood blood = new Blood();

            Circle circle2; //did not make a new object
            circle2 = circle; //reference var, points to the same object
            circle2.myInt = 1; //changes myInt in circle as well

            Shape shape; //= new Shape(); can't make a new shape object ass the class is abstract
            shape = rectangle; //polymorphism, uses relationships between classes
            shape.DrawMe(); //drawme method in rectangle, not shape
            //shape.IsSquare can't be accessed, however, as it is not in the parent class

            IDrawObject drawobject;
            drawobject = blood;
            drawobject.DrawMe();

            DrawObject(circle); //can use DrawObject method below as these are the child of IDrawObject
            DrawObject(cylinder);
        }

        static void DrawObject (IDrawObject drawObject)
        {
            drawObject.DrawMe();
        }

        static void PrintAreaOfShape(Shape shape)
        {
            //if (shape.GetType() == typeof(Circle)) 
            if(shape is Circle)
            {
                Console.WriteLine("Your shape is a circle");
            }
            if(shape.GetType() == typeof(Rectangle)) 
            {
                Rectangle r;
                r = (Rectangle)shape;

                if(r.IsSquare)
                {
                    Console.WriteLine("Your shape is a square");
                }
            }

            if (shape is IDrawObject) 
            {
                IDrawObject drawObject = (IDrawObject)shape;
                drawObject.DrawMe();
            }

            Console.WriteLine("The area is: " + shape.Area());
        }

        void MyMethod() //as this isnt static
        {

        }
    }
}
