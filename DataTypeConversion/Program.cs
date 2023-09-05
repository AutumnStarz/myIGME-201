using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doubleNum = 99999.999;
            float floatNum = 99.9F;
            long longInt = -12345678;
            ulong ulongNum = 12345678;
            int intNum = -786;
            uint uintNum = 786;
            short shortInt = -786;
            ushort ushortInt = 456;
            byte byteNum = 254;
            sbyte sbyteNum = -123;

            //implicit
            longInt = shortInt;
            uintNum = byteNum;
            //byteNum = shortInt Can't convert due to one data type being larger (recieving is smaller)

            //explict casting
            byteNum = (byte)shortInt;

            try
            {
                byteNum = checked((byte)shortInt);
                byteNum = Convert.ToByte(shortInt);
            }
            catch
            {
                //output text that informs user that data will be lost
            }
        }
    }
}
