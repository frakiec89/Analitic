using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Tests
{
    [TestClass()]
    public class AnaliticTests
    {

        Analitic analitic = new Analitic();

        [TestMethod()]
        public void GetDateTimesTest()
        {

            var data = new List<DateTime> 
            { 
                DateTime.Parse("11.12.2020") ,
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("13.12.2020") ,
            };


            var expected = new List<DateTime>() { DateTime.Parse("11.12.2020") ,
              DateTime.Parse("12.12.2020"), DateTime.Parse("13.12.2020")
            };

            var actual  = analitic.GetDateTimes(data);

            Assert.AreEqual(expected.Count, actual.Count);

            for ( int  i = 0; i<expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void GetDateTimesTest1()
        {

            var data = new List<DateTime>
            {
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("12.12.2020") ,
                DateTime.Parse("13.12.2020") ,
                DateTime.Parse("11.12.2020") ,
            };


            var expected = new List<DateTime>()
            {   
                DateTime.Parse("11.12.2020") ,
                DateTime.Parse("13.12.2020"),
                DateTime.Parse("12.12.2020"),
            };

            var actual = analitic.GetDateTimes(data);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}