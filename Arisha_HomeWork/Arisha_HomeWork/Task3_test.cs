using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task3_test
    {
        [TestCase(16, 7)]
        [TestCase(942, 6)]
        [TestCase(132189, 6)]
        [TestCase(493193, 2)]

        public void DigitalRootTest(int input, int output)
        {
            var res = Task3.DigitalRoot(input);
            Assert.AreEqual(res, output);
        }
    }
}
