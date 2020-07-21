
using System.Windows.Forms;

namespace CarWorkshop.Helpers
{
    /// <summary>
    /// Klasa pomocnicza do sprawdzania walidacji pól na formularzu
    /// </summary>
    public class CarValidator
    {
        private readonly string model;
        private readonly string vin;
        private readonly string brand;
        private readonly string productionYear;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">Model auta</param>
        /// <param name="vin">Vin auta </param>
        /// <param name="brand"> Marka auta</param>
        /// <param name="productionYear">Rok produckji </param>
        public CarValidator(string model, string vin, string brand, string productionYear)
        {
            this.model = model;
            this.vin = vin;
            this.brand = brand;
            this.productionYear = productionYear;
        }
        /// <summary>
        /// Metoda sprawdzająca czy pola nie są nullami lub mają same puste znaki
        /// </summary>
        /// <returns></returns>
        public bool IsDataValid()
        {
            return !string.IsNullOrWhiteSpace(model) &&
                    !string.IsNullOrWhiteSpace(vin) &&
                    !string.IsNullOrWhiteSpace(brand) &&
                    !string.IsNullOrWhiteSpace(productionYear);
        }
    }
}