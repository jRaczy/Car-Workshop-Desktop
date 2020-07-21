using CarWorkshop.Helpers;
using CarWorkshop.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWorkshop.Test
{
    /// <summary>
    /// Klasa stworzona do testów testująca CarsService
    /// </summary>
    [TestClass]
    public class CarsServiceTests
    {
        /// <summary>
        /// Metoda dodająca nowy obiekt na bazie i sprawdzająca czy wartości nie są nullami
        /// </summary>
        [TestMethod]
      
        public void Add()
        {
            var carRepositoryMock = new CarRepositoryMock();
            var carsService = new CarsService(carRepositoryMock);

            carsService.Add(12, 1234, "anrej", "anrej", "anrej", 12);

            Assert.IsNotNull(carRepositoryMock.MockedCars.FirstOrDefault());
        }
    }
}
