﻿using System.Collections.Generic;
using System.ComponentModel;

namespace CarWorkshopDomain.Repositories
{
    /// <summary>
    /// Interfejs Dla ClientRepository
    /// </summary>
    public interface IClientRepository
    {
        void Add(string address, string email, string name, string phoneNumber, string surname, string comments);
        
            List<Client> GetAll();

            void Edit(Client client);
    }
}