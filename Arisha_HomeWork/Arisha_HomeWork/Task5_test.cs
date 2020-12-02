﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arisha_HomeWork
{
    class Task5_test
    {
        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("", "")]

        public void MeetingTest(string input_str, string output_str)
        {
            var res = Task5.Meeting(input_str);
            Assert.AreEqual(res, output_str);
        }
    }
}
