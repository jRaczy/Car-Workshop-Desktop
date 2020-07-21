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
    /// Klasa odpowiadająca za warstwę logiczną formularza AddVisit
    /// </summary>
    public partial class AddVisit : Form
    {
        bool done = false;
        /// <summary>
        /// Propercja CarId
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// Konstruktor klasy Otwiera formularz oraz tworzy obiekt ServiceRepository oraz zaczytuje wartości 
        /// </summary>
        /// <param name="carId">Przekazywany Id auta</param>
        public AddVisit(int carId)
        {
            CarId = carId;
            InitializeComponent();
            var services = new ServiceRepository().GetByCarId(carId);
            dataGridView1.DataSource = services;
        }
        /// <summary>
        /// Metoda czyszcząca wartości TextBox na formularzu
        /// </summary>
        private void ClarTextValue()
        {
            tbDescription.Text = "";
            tbPrize.Text = "";
            tbService.Text = "";
            mtbDateFrom.Text = "";
            mtbDateTo.Text = "";
        }
        /// <summary>
        /// Metoda sprawdzająca czy pola nie są pust lub nullami lub czy nie zawierają samych pustych znaków
        /// </summary>
        /// <returns> Zwraca prawdę lub fałsz</returns>
        private bool AreFieldsNullOrEmpty()
        {
            if (tbDescription != null && tbPrize !=null && tbService != null && tbService != null && mtbDateTo !=null && mtbDateFrom !=null && !string.IsNullOrWhiteSpace(tbService.Text) && !string.IsNullOrWhiteSpace(tbPrize.Text) && !string.IsNullOrWhiteSpace(tbDescription.Text) && !string.IsNullOrWhiteSpace(mtbDateFrom.Text) && !string.IsNullOrWhiteSpace(mtbDateTo.Text))
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(AreFieldsNullOrEmpty())
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            ServiceRepository sr = new ServiceRepository();
            sr.Add(mtbDateFrom.Text, mtbDateTo.Text, tbService.Text, tbService.Text, Convert.ToInt32(tbPrize.Text), done, CarId);
            ClarTextValue();
            var visit = new ServiceRepository().GetByCarId(CarId);
            dataGridView1.DataSource = visit;
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
      
        /// /// <summary>
        /// Metoda aby w polu nie było można wpisywać nic innego niż cyfry
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void tbPrize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
