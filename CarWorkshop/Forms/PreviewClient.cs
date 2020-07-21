using CarWorkShop.Infrastucture.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.Forms
{
    public partial class PreviewClient : Form
    {
        public int ClientId { get; set; }
        /// <summary>
        ///  Konstruktor klasy otwierający formularz
        /// </summary>
        /// <param name="clientId"></param>
        public PreviewClient(int clientId)
        {
            ClientId = clientId;
            InitializeComponent();
            InitClient();
        }
        /// <summary>
        /// Metoda zaczytująca wartości z bazy danych i uzupełniająca pola
        /// </summary>
        private void InitClient()
        {
            var cr = new ClientRepository();
            var clients = cr.GetClientsById(ClientId).FirstOrDefault();

            tbName.Text = clients.Name;
            tbAddress.Text = clients.Address;
            tbComments.Text = clients.Comments;
            tbEmail.Text = clients.Email;
            tbSurname.Text = clients.Surname;
            tbPhoneNumber.Text = clients.PhoneNumber.ToString();
        }
    }
}
