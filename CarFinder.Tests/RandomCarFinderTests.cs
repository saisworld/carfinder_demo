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
    public class RandomCarFinderTests
    {
        [Test]
        public void ShouldGenerateRandomValuesAndReturnPosition()
        {
            var carFinder = new RandomCarFinder();
            var result = carFinder.Find(3);
            Assert.That(()=> result != 0);
        }



    }
}
