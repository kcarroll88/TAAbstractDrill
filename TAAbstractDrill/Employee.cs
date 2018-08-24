using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAAbstractDrill
{
    class Employee : Person
    {
        public override void SayName()
        {
            string fullName = FirstName + LastName;
            Console.WriteLine("The full name is : {0}", fullName);
        }
    }
}
