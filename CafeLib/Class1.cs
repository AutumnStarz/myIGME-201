using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood
        {
            get;
        }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;
        public string Mood {
            get
            {
                return name;
            }
        }
    }

    public class Waiter : IMood
    {
        public string name;

        public string Mood
        {
            get
            {
                return name;
            }
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual byte AddSugar(byte amount)
        {
            return amount;
        }

        public abstract void Steam();

        public HotDrink(string brand)
        {

        }
       
        
    }

    public class CupOfCoffee : HotDrink, ITakeOrder 
    {
        public string beanType;
        public override void Steam() 
        {
            
        }

        public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }

    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }
        public CupOfTea(bool customerIsWealthy, string brand) : base(brand)
        {

        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            set { 
                source = value; 
            }
        }
        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public override byte AddSugar(byte amount)
        {
            return amount;
        }

        public CupOfCocoa (bool marshmallows) : base("Expensive Organic Brand")
        {
            
        }
    }
    public class Class1
    {
    }
}
