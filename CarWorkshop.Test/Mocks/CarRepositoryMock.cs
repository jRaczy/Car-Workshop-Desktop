using CarWorkshopDomain;
using CarWorkshopDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarWorkshop.Test.Mocks
{
    public class CarRepositoryMock : ICarRepository
    {
        public List<Car> MockedCars { get; private set; }
        /// <summary>
        /// Metoda tworząca nową listę obiektów Car
        /// </summary>
        public CarRepositoryMock()
        {
            MockedCars = new List<Car>();
        }
        /// <summary>
        /// Metoda 
        /// </summary>
        /// <param name="vIN">Vin auta</param>
        /// <param name="yearOfProduction">Rok produkcji auta</param>
        /// <param name="brand">Marka auta</param>
        /// <param name="model">Model auta</param>
        /// <param name="comments">Komentarze dotyczące auta</param>
        /// <param name="clientId">Id klienta do którego należy auto</param>
        public void Add(int vIN, int yearOfProduction, string brand, string model, string comments, int clientId)
        {
            var car = new Car
            {
                VIN = vIN,
                YearOfProduction = yearOfProduction,
                Brand = brand,
                Model = model,
                Comments = comments,
                ClientID = clientId
            };

            MockedCars.Add(car);
        }
      
        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByClientId(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
