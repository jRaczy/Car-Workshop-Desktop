using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastucture.Queries
{
    //Klasa przechowuje wszystkie Query które są używane akutalnie
    public static class CarWorkShopQueries
    {
        public static string AddServiceVisit => "INSERT INTO CarVisit(CarID,DateFrom,DateTo,Service,Description,Price,IsDone) Values (@CarID,@DateFrom,@DateTo,@Service,@Description,@Price,@IsDone);";
        public static string GetAllServices => "Select * FROM CarVisit;";
        public static string GetServiceById => "Select * FROM Service where Id=@Id;";
        public static string DeleteServiceById => "DELETE FROM Service WHERE Id=@Id;";
        public static string GetAllClients => "Select * FROM Client";
        public static string AddClient => "INSERT INTO Client (Name,Surname,Email,PhoneNumber,Comments,Address) Values (@Name,@Surname, @Email, @PhoneNumber, @Comments,@Address);";
        public static string UpdateClient => "UPDATE  Client SET Name = @Name , Surname = @Surname , Email = @Email , Comments=@Comments , Address= @Address WHERE Id = @Id";
        public static string GetClientById => "Select * from Client where Id =@Id";
        public static string DeleteClientById => "DELETE FROM Client WHERE Id=@Id";
        public static string AddCar => "INSERT INTO Car (VIN,YearOfProduction,Brand,Model,Comments, ClientId) Values (@VIN,@YearOfProduction, @Brand, @Model, @Comments,@ClientId);";
        public static string GetAllCars => "Select * FROM Car";
        public static string GetCarById => "Select * FROM Car WHERE Id =@Id";
        public static string UpdateCar => "UPDATE  Car SET Brand = @Brand , Model = @Model , YearOfProduction = @YearOfProduction , Comments=@Comments , VIN= @VIN WHERE Id = @Id";
        public static string DeleteCarById => "DELETE FROM Car WHERE Id=@Id";
        public static string GetAllVisistsUnDone => "select * from CarVisit where IsDone = 'false'";
        public static string GetVistById => "select * from CarVisit where ID=@ID;";
        public static string UpdateVisist => "UPDATE  CarVisit SET DateFrom = @DateFrom , DateTo = @DateTo , Service = @Service , Description=@Description , Price= @Price,IsDone=@IsDone WHERE Id = @Id;";
        public static string DeleteVisitById => "DELETE FROM CarVisit WHERE ID=@Id";
    }
}
