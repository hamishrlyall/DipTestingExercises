using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace UnitTestExercises.Mocking
{
    class FakeBus : Bus
    {
        public FakeBus(IPerson pDriver, int pMaxFuel, int pCurrent, int pLitresPerKM, int pMaxPassengers) : base(pDriver, pMaxFuel, pCurrent, pLitresPerKM, pMaxPassengers)
        {
        }
    }
}
