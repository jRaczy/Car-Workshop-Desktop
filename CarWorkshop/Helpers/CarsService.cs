using CarWorkshopDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Helpers
{
    /// <summary>
    /// Klasa 
    /// </summary>
    public class CarsService
    {
        private readonly ICarRepository carRepository;
        /// <summary>
        /// Kosntruktor klasy przyjmuje tylko obiekty typu carRepository które dziedziczą ICarRepository
        /// </summary>
        /// <param name="carRepository"></param>
        public CarsService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
        /// <summary>
        /// Metoda dodająca auto na bazę danych
        /// </summary>
        /// <param name="vIN">Vin auta</param>
        /// <param name="yearOfProduction">Rok produkcji auta</param>
        /// <param name="brand">Marka auta</param>
        /// <param name="model">Model auta</param>
        /// <param name="comments">Komentarze dotyczące auta</param>
        /// <param name="clientId">Id klienta do którego należy auto</param>
        public void Add(int vIN, int yearOfProduction, string brand, string model, string comments, int clientId)
        {
            carRepository.Add(vIN, yearOfProduction, brand, model, comments, clientId);
        }
    }
}
