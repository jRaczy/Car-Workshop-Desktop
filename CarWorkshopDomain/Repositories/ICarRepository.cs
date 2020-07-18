using System.Collections.Generic;
using System.ComponentModel;

namespace CarWorkshopDomain.Repositories
{
    //Interfejs Dla CarRepository
    public interface ICarRepository
    {
        void Add(int vIN, int yearOfProduction, string brand, string model, string comments, int clientId);
        List<Car> GetAll();

        List<Car> GetByClientId(int clientId);
    }
}