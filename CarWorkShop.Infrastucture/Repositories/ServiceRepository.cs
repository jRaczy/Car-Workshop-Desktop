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
{//Klasa przechowuje metody dla obiektów Visits
    public class ServiceRepository: BaseRepository
    {
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
        public List<CarVisit> GetByCarId(int carId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var service = connection.Query<CarVisit>(CarWorkShopQueries.GetAllServices).ToList();

                return service.Where(x => x.CarID == carId).ToList();
            }
        }
        public List<CarVisit> GetAll()
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var visists = connection.Query<CarVisit>(CarWorkShopQueries.GetAllVisistsUnDone).ToList();

                return visists;
            }
        }
        public List<CarVisit> GetVistById(int id)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var visits = connection.Query<CarVisit>(CarWorkShopQueries.GetVistById, new { ID = id }).ToList();
                return visits;
            }
        }
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
