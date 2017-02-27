using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Agents.Implementations;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CarFinder.Tests
{
    [TestFixture()]
    public class StartingZeroCarFinderTests
    {
        [Test]
        public void ShouldReturnValue()
        {
            var carFinder = new StartingZeroCarFinder();
            var result = carFinder.Find(10);
            Assert.That(()=> result != 0);
        }

        [Test]
        public void ShouldReturnDifferentValuesOnCallingMultipleTimes()
        {
            var carFinder = new StartingZeroCarFinder();
            var firstResult = carFinder.Find(10);
            var secondResult = carFinder.Find(1);

            Assert.That(()=> firstResult != secondResult);
        }
    }
}
