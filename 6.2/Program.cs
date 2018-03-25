using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        internal class CoreClass
        {
            private Contact _FirstEmergencyContact;

            public Contact FirstEmergencyContact
            {
                get
                {
                    return _FirstEmergencyContact;
                }
                set
                {
                    SetProperty(ref _FirstEmergencyContact, value);
                }
            }

            private Contact _SecondEmergencyContact;

            public Contact SecondEmergencyContact

            {
                get
                {
                    return _SecondEmergencyContact;
                }

                set
                {
                    SetProperty(ref _FirstEmergencyContact, value);
                }
            }

            private Contact SetProperty(ref Contact x, object val)
            {
                return x;
            }
        }

        internal class Contact
        {


        }
    }
}
