﻿using CarWorkShop.Infrastucture.Repositories;
using CarWorkshopDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.Forms
{
    public partial class EditClient : Form
    {
        public int ClientId { get; set; }
        public Action<object, EventArgs> RefreshGrid;
        public EditClient(int clientId)
        {
            ClientId = clientId;
            InitializeComponent();
            InitClient();
        }
        //Metoda pobirająca wartości z bazy danych i uzupełniająca wartości  pól
        private void InitClient()
        {
            var cr = new ClientRepository();
            var clients = cr.GetClientsById(ClientId).FirstOrDefault();

            tbName.Text = clients.Name;
            tbSurname.Text = clients.Surname;
            tbAddress.Text = clients.Address;
            tbComments.Text = clients.Comments;
            tbEmail.Text = clients.Email;
            tbPhoneNumber.Text = clients.PhoneNumber.ToString();
        }
        //Metoda która zaczytuje wartości z pól i zapisuje je na bazie
        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                Id = ClientId,
                Name = tbName.Text,
                Surname = tbSurname.Text,
                Address = tbAddress.Text,
                Comments = tbComments.Text,
                Email = tbEmail.Text,
                PhoneNumber = Convert.ToInt32(tbPhoneNumber.Text)
            };
            var cr = new ClientRepository();
             cr.Edit(client);
            if (RefreshGrid != null)
                RefreshGrid(sender, e);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
