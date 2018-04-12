﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace UnitTestExercises.Mocking
{
    class FakeMotorVehicle : MotorVehicle
    {
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM)
        {
        }
    }
}
