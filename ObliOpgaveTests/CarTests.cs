using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObliOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliOpgave.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car car = new Car() { Id = 2, Model = "Mercedes E Klasse", LicensePlate = "DA23543", Price = 420000 };
        Car carNegativePrice = new Car() { Id = 5, Model = "Tesla S Model", LicensePlate = "GR32683", Price = -79500 };
        Car carUnknownModel = new Car() { Id = 53, Model = "C63", LicensePlate = "B1TC01N", Price = 10043950 };
        Car carUnknownId = new Car() { Id = -34, Model = "Bugatti Chiron", LicensePlate = "T8", Price = 35300000 };
        Car carUnknownLicensePlate = new Car() { Id = 43, Model = "Audi R8", LicensePlate = "CH435439", Price = 2700000 };

        [TestMethod()]
        public void ValidatePriceTest()
        {

            // Act & Assert
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carNegativePrice.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateIdTest()
        {
            // Act & Assert
            car.ValidateId();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carUnknownId.ValidateId());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {

            // Act & Assert
            car.ValidateModel();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carUnknownModel.ValidateModel());
        }

        [TestMethod()]
        public void ValidateLicensePlate()
        {

            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carUnknownLicensePlate.ValidateLicensePlate());
        }
    }

}