using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UT2FriendClass
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        public Friend Clone()
        {
            return new Friend();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            enemy = friend.Clone();

            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender. Address Unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");

        }
    }
}
