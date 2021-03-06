﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task6_test
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(9, -1)]
        [TestCase(111, -1)]
        [TestCase(531, -1)]

        public void NextBiggerTest(int input, int output)
        {
            var res = Task6.NextBigger(input);
            Assert.AreEqual(res, output);
        }
    }
}
