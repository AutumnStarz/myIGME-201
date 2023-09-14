using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace MethodEnumsStruct
{
    //enums can be declared in namespace or within class
    // these enums are accessible to all code in the namespace

    //create your own data type with enum
    //private by default
    enum EGenderPronouns // : int by default
    {
        him, //0
        her,
        them
    }

    //can specify public accessibility
    public enum ECollegeYear : byte
    {
        freshman = 26,
        sophomore = 25,
        junior = 24,
        senior = 23
    }

    //similar collected information can be held within a structs
    struct StudentStruct
    {
        public string sName;
        private string sPassword;
        public EGenderPronouns eGender;
        public ECollegeYear eCollegeYear;
        public double dGrade;

        //property - a method combined with a field public string PropertyField {get; set;}

        
        public string Password
        {
            get
            {
                return (Decrypt(this.sPassword)); //this means that we are accessing the field in the current context
            }
            set
            {
                this.sPassword = Encrypt(value);
            }
        }
        private string Decrypt(string pw)
        {
            string decryptedValue = "";
            char[] cPassword;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
