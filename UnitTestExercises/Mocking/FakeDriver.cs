﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipTestingExercises;

namespace UnitTestExercises.Mocking
{
    class FakeDriver : Driver
    {

        public FakeDriver(string pFname, string pLname, string pGender, string pLicence) : base(pFname, pLname, pGender, pLicence)
        {
        }
    }
}
