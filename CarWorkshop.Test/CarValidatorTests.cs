using CarWorkshop.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CarWorkshop.Test
{
    /// <summary>
    /// Klasa testujaca walidację 
    /// </summary>
    [TestClass]
    
    public class CarValidatorTests
    {
        /// <summary>
        /// Metoda sprawdza czy podane danę są poprawnie walidowane
        /// </summary>
        [TestMethod]
        public void IsDataValid_IsValid()
        {
            var carValidator = new CarValidator("asd","zxc", "zxc", "zxc");

            Assert.IsTrue(carValidator.IsDataValid());
        }
    }
}
