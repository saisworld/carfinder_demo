using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Models;
using NUnit.Framework;

namespace CarFinder.Tests
{
    [TestFixture]
    public class CarModelTests
    {
        [Test]
        public void ShouldCalculateRandomValues()
        {
            var carModel = new Car(new CarFinderManager());
            Assert.IsNull(carModel.InitialPosition);
            Assert.IsNull(carModel.InitialVelocity);
            carModel.RandomValues();
            Assert.IsNotNull(carModel.InitialPosition);
            Assert.IsNotNull(carModel.InitialVelocity);
        }

        [Test]
        public void ShouldStopGameAfterItWasStarted()
        {
            var carModel = new Car(250, 100, new CarFinderManager());
            carModel.Play();
            carModel.Stop();
            Assert.IsFalse(carModel.IsGameRunning);
        }

        [Test]
        public void ShouldReturnResultsAfterStaringGame()
        {
            var carModel = new Car(250, 100, new CarFinderManager());
            carModel.GameEnd += (sender, args) =>
            {
                Assert.IsNotNull(carModel.CarFoundResults);
                Assert.AreEqual(carModel.CarFoundResults.Count, 2);

            };
            carModel.Play();
        }











    }
}
