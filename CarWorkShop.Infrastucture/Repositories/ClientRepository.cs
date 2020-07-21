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
    /// Klasa przechowuje metody dla obiektów Client
    /// </summary>
    public class ClientRepository :BaseRepository, IClientRepository
    {
        /// <summary>
        /// Metoda dodająca Klienta do bazy danych
        /// </summary>
        /// <param name="address">Adres zamieszkania klienta</param>
        /// <param name="email">Email klienta </param>
        /// <param name="name">Imię klienta</param>
        /// <param name="phoneNumber">Numer telefonu klienta </param>
        /// <param name="surname">Nazwisko klienta</param>
        /// <param name="comments">Komentarze i dodatkowe informacje o kliencie</param>
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
        /// <summary>
        /// Metoda która akutalizuje ifnoramcje o kliencie
        /// </summary>
        /// <param name="client">Obiekt klienta</param>
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
        /// <summary>
        /// metoda zwraca wszystkich klientów z bazy
        /// </summary>
        /// <returns></returns>
        public List<Client> GetAll()
        {
            using (var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var clients = connection.Query<Client>(CarWorkShopQueries.GetAllClients).ToList();

                return clients;
            }
        }
        /// <summary>
        /// Metoda zwraca klienta po jego id
        /// </summary>
        /// <param name="clientId">Id klienta</param>
        /// <returns></returns>
        public List<Client> GetClientsById(int clientId)
        {
            using(var connection = new SqlConnection(ConncetionString))
            {
                connection.Open();
                var client = connection.Query<Client>(CarWorkShopQueries.GetClientById,new { Id = clientId }).ToList();
                return client;
            }
        }
        /// <summary>
        ///  Metoda usuwa klienta z podanym ID
        /// </summary>
        /// <param name="clientId">Id klienta</param>
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
