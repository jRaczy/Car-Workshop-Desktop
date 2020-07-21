using CarWorkshopDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkShop.Infrastucture.Queries;
using CarWorkshopDomain;
using Dapper;

namespace CarWorkShop.Infrastucture.Repositories
{
    /// <summary>
    /// Klasa przechowuje metody dla obiektów Visits
    /// </summary>
    public class ServiceRepository: BaseRepository
    {
        /// <summary>
        /// Metoda dodaje rekord do bazy dotyczący wizyt
        /// </summary>
        /// <param name="dateFrom">Data od kiedy będzie trwała wizyta</param>
        /// <param name="dateTo">Data do kiedy będzie trwała wizyta</param>
        /// <param name="service">Nazwa usługi</param>
        /// <param name="description">Opis usług</param>
        /// <param name="price">Cena</param>
        /// <param name="isDone">Wartość bool mówiąca czy zakończona jest już wizyta</param>
        /// <param name="carId">ID auta</param>
        public void Add(string dateFrom,string dateTo, string service, string description, int price,bool isDone,int carId)
        {
            try
            {
                using (var connection = new SqlConnection(ConncetionString))
                {
                    connection.Open();
                    var affectedRows = connection.Execute(CarWorkShopQueries.AddServiceVisit, new CarVisit { DateFrom=dateFrom,DateTo=dateTo,Service=service,Description=description,Price =Convert.ToInt32(price),IsDone=isDone,CarID=carId});

                    Console.WriteLine(affectedRows);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Metoda zwracająca z bazy wizyte po ID auta
        /// </summary>
        /// <param name="carId">ID auta</param>
        /// <returns></returns>
        public List<CarVisit> GetByCarId(int carId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var service = connection.Query<CarVisit>(CarWorkShopQueries.GetAllServices).ToList();

                return service.Where(x => x.CarID == carId).ToList();
            }
        }
        /// <summary>
        /// Metoda zwracają ca wszystkie wizyty z bazy
        /// </summary>
        /// <returns>Zwraca liste wizyt</returns>
        public List<CarVisit> GetAll()
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var visists = connection.Query<CarVisit>(CarWorkShopQueries.GetAllVisistsUnDone).ToList();

                return visists;
            }
        }
        /// <summary>
        /// Metoda wszyukuje i zwraca wizytę po ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarVisit> GetVistById(int id)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var visits = connection.Query<CarVisit>(CarWorkShopQueries.GetVistById, new { ID = id }).ToList();
                return visits;
            }
        }
        /// <summary>
        /// Metoda edytuje wartości na bazie obiektu CarVisit czyli wizyty
        /// </summary>
        /// <param name="visit">Obiekt wizyty w warszatcie</param>
        public void Edit(CarVisit visit)
        {
            try
            {

                using (var connection = new SqlConnection(ConncetionString))
                {
                    connection.Open();

                    var affectedRows = connection.Execute(CarWorkShopQueries.UpdateVisist, new CarVisit { DateFrom=visit.DateFrom,DateTo=visit.DateTo,Service=visit.Service,Description=visit.Description,Price=visit.Price,IsDone=visit.IsDone,ID=visit.ID });

                    Console.WriteLine(affectedRows);
                }
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Metoda usuwa wizyte po jej ID
        /// </summary>
        /// <param name="id">ID wizyty</param>
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var visit = connection.Query<CarVisit>(CarWorkShopQueries.DeleteVisitById, new { Id = id });
            }
        }
    }
}
