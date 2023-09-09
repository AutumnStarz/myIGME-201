using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    static internal partial class Program

    {
        static void Main(string[] args)
        {
            double doubleNum = 99999.999;
            float floatNum = 99.9F; //unsigned means it can't go negative
            long longInt = -12345678; //signed means it can go negative
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

                byteNum = byte.Parse(shortInt.ToString()); //make sure to put in a try-catch
                bool bValid = byte.TryParse(shortInt.ToString(),out byteNum);
            }
            catch
            {
                //output text that informs user that data will be lost
            }

            // int/int = int
            doubleNum = longInt / shortInt; //will output a int
            doubleNum = (double)longInt / shortInt; //can output a double (explicity casted by using "(double)")
            doubleNum = 1.00 * longInt / shortInt; //can output a double

            shortInt = (short)3.14; //shortInt = 3 as not a double
            myDivider(shortInt); //using keyword partial, we can access methods across files

        }
    }
}
