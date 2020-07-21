using CarWorkshopDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkShop.Infrastucture.Queries;
using CarWorkshopDomain;
using Dapper;

namespace CarWorkShop.Infrastucture.Repositories
{//Klasa Przechowuje metody dla obiektów Car
   public class CarRepository : BaseRepository, ICarRepository
    {
        /// <summary>
        /// Metoda która aktualizuje obiekt na bazie
        /// </summary>
        /// <param name="car">Obiekt auta </param>
        public void Edit(Car car)
        {
            try
            {

                using (var connection = new SqlConnection(ConncetionString))
                {
                    connection.Open();

                    var affectedRows = connection.Execute(CarWorkShopQueries.UpdateCar, new Car {  Brand= car.Brand , Model = car.Model, YearOfProduction = car.YearOfProduction, Comments = car.Comments, VIN = car.VIN, Id = car.Id });

                    Console.WriteLine(affectedRows);
                }
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Metoda która służy do dodawania nowego obiektu na bazę
        /// </summary>
        /// <param name="vIN">Vin auta</param>
        /// <param name="yearOfProduction">Rok produkcji auta</param>
        /// <param name="brand">Marka auta</param>
        /// <param name="model">Model auta</param>
        /// <param name="comments">Komentarze dotyczące auta</param>
        /// <param name="clientId">Id klienta</param>
        public void Add(int vIN,int yearOfProduction, string brand,string model, string comments, int clientId)
        {
            try
            {

                using (var connection = new SqlConnection(ConncetionString))
                {
                    connection.Open();
                    var affectedRows = connection.Execute(CarWorkShopQueries.AddCar, new Car { VIN = Convert.ToInt32(vIN), YearOfProduction =Convert.ToInt32(yearOfProduction), Brand = brand,Model=model,Comments=comments,  ClientID = clientId });

                    Console.WriteLine(affectedRows);


                }
            }
            catch (Exception e)
            {
            
            }
        }
        /// <summary>
        /// Metoda do wyciągnięcia wszystkich obiektów z tabeli Car
        /// </summary>
        /// <returns></returns>
        public List<Car> GetAll()
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var cars = connection.Query<Car>(CarWorkShopQueries.GetAllCars)
                    .ToList();

                return cars;
            }
        }
        /// <summary>
        /// Metoda do wyszukania obiektu z bazy po ID
        /// </summary>
        /// <param name="clientId">Id klienta po którym jest wyszukiwane</param>
        /// <returns></returns>
        public List<Car>  GetByClientId(int clientId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var cars = connection.Query<Car>(CarWorkShopQueries.GetAllCars).ToList();

                return cars.Where(x=>x.ClientID == clientId).ToList();
            }
        }
        /// <summary>
        /// Metoda do wyszukania obiektu z bazy po ID
        /// </summary>
        /// <param name="CarId">Id auta po którym jest wyszukiwane</param>
        /// <returns></returns>
        public List<Car> GetCarById(int CarId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var cars = connection.Query<Car>(CarWorkShopQueries.GetCarById,new { Id = CarId }).ToList();
                return cars;
            }
        }
        /// <summary>
        /// Metoda do usuwania wizyt po ID
        /// </summary>
        /// <param name="id">Id Auta</param>
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var car = connection.Query<Car>(CarWorkShopQueries.DeleteCarById, new { Id = id });
            }
        }
    }   
}
