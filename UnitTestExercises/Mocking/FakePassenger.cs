using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace UnitTestExercises.Mocking
{
    class FakePassenger : Passenger
    {
        public FakePassenger(string pFname, string pLname, string pGender, string pTicketType) : base(pFname, pLname, pGender, pTicketType)
        {
        }
    }
}
