using CarWorkShop.Infrastucture.Repositories;
using CarWorkshopDomain;
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
    /// <summary>
    /// Klasa odpowiadająca za wartość logiczną do Formularza AddClient
    /// </summary>
    public partial class AddClient : Form
    {
      /// <summary>
      /// Obiekt klienta
      /// </summary>
        public Client Client { get; set; }
        
        
        public Action<object, EventArgs> RefreshGrid;
        /// <summary>
        /// Konstruktor klasy który otwiera formularz
        /// </summary>
        public AddClient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda ustawia wartość tekstową TextBoxa
        /// </summary>
        /// <param name="client">Obiekt klienta</param>
        public void InitControls(Client client)
        {
            tbName.Text = client.Name;
        }
       /// <summary>
       /// Metoda uniemożliwająca edycję TextBoxa
       /// </summary>
        public void DisableControls()
        {
            tbName.Enabled = false;
        }
        /// <summary>
        /// Metoda czyszcząca wartości TextBox na formularzu
        /// </summary>
              public void ClearTextValue()
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbPhoneNumber.Text="";
            tbSurname.Text="";
        }
       /// <summary>
       /// Metoda sprawdzająca czy pola nie są pust lub nullami lub czy nie zawierają samych pustych znaków
       /// </summary>
       /// <returns> Zwraca prawdę lub fałsz</returns>
        private bool AreFieldsNullOrEmpty()
        {
            if (tbAddress != null && tbEmail != null && tbName != null && tbPhoneNumber != null && tbSurname!=null && !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                !string.IsNullOrWhiteSpace(tbEmail.Text) && !string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPhoneNumber.Text)&& !string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Metoda sprawdza walidacje wartości pól dodaje nowy obiekt do bazy danych, czyści wartości pól oraz zamyka okno i odświeża widok Grida
        /// </summary>
        /// <param name="sender">Przycisk dodający zadnaie</param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (AreFieldsNullOrEmpty())
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            var cr = new ClientRepository();
            cr.Add(tbAddress.Text, tbEmail.Text, tbName.Text, tbPhoneNumber.Text, tbSurname.Text,tbComments.Text);
            ClearTextValue();
            this.Close();
            RefreshGrid(sender, e);
        }
        /// <summary>
        /// Metoda aby w polu nie było można wpisywać nic innego niż cyfry
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        /// <summary>
        /// Metoda zamykająca formularz
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
