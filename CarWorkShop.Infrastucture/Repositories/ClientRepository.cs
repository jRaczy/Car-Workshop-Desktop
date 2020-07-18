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
{//Klasa przechowuje metody dla obiektów Client
    public class ClientRepository :BaseRepository, IClientRepository
    {
        public void Add(string address, string email, string name, string phoneNumber, string surname, string comments)
        {
            try
            {

                using (var connection = new SqlConnection(ConncetionString))
                {
                  connection.Open();

                  var affectedRows = connection.Execute(CarWorkShopQueries.AddClient, new Client { Name=name, Surname=surname,Email=email, PhoneNumber=Convert.ToInt32(phoneNumber),Comments=comments,Address=address });

                  Console.WriteLine(affectedRows);
                }
            }
            catch (Exception e)
            {
                
            }
        }

        public void Edit(Client client)
        {
            try
            {

                using (var connection = new SqlConnection(ConncetionString))
                {
                    connection.Open();

                    var affectedRows = connection.Execute(CarWorkShopQueries.UpdateClient, new Client { Name = client.Name, Surname = client.Surname, Email = client.Email, Comments = client.Comments, Address = client.Address,Id = client.Id });

                    Console.WriteLine(affectedRows);
                }
            }
            catch (Exception e)
            {
              
            }
        }

        public List<Client> GetAll()
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var clients = connection.Query<Client>(CarWorkShopQueries.GetAllClients).ToList();

                return clients;
            }
        }
        public List<Client> GetClientsById(int clientId)
        {
            using(var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var client = connection.Query<Client>(CarWorkShopQueries.GetClientById,new { Id = clientId }).ToList();
                return client;
            }
        }
        public void Delete(int clientId)
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var client = connection.Query<Client>(CarWorkShopQueries.DeleteClientById, new { Id = clientId }).FirstOrDefault();  
            }
        }
    }
}
