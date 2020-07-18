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
   public class CarRepository : BaseRepository,ICarRepository
    {
        //Metoda która aktualizuje obiekt na bazie
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
        //Metoda która służy do dodawania nowego obiektu na bazę
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
        //Metoda do wyciągnięcia wszystkich obiektów z tabeli Car
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
        //Metoda do wyszukania obiektu z bazy po ID
        public List<Car>  GetByClientId(int clientId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var cars = connection.Query<Car>(CarWorkShopQueries.GetAllCars).ToList();

                return cars.Where(x=>x.ClientID == clientId).ToList();
            }
        }
        //Metoda do wyszukania obiektu z bazy po ID
        public List<Car> GetCarById(int CarId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var cars = connection.Query<Car>(CarWorkShopQueries.GetCarById,new { Id = CarId }).ToList();
                return cars;
            }
        }
        //Metoda do usuwania wizyt po ID
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
