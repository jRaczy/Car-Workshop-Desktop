using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarWorkshop.Helpers;
using CarWorkShop.Infrastucture.Repositories;
using CarWorkshopDomain;

namespace CarWorkshop.Forms
{
    /// <summary>
    /// Interakcja logiczna dla AddCar.cs
    /// </summary>
    public partial class AddCarForm : Form
    {

        private readonly CarsService carsService;
        /// <summary>
        ///  Propercja ClientId trzyma infromacje o Id clienta
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Konstruktor klasy tworzący nowy obiekt CarService i otwiera formularz wraz z zaczytaniem danych do dataGridView1
        /// </summary>
        /// <param name="clientId"> Jest to id klienta które przekazujemy</param>
        /// <param name="clientName">Imię klienta które przekazujemy</param>
        public AddCarForm(int clientId, string clientName)
        {
            carsService = new CarsService(new CarRepository());
            ClientId = clientId;
            InitializeComponent();
            label1.Text += clientName;

            var cars = new CarRepository().GetByClientId(clientId);
            dataGridView1.DataSource = cars;
        }
        /// <summary>
        /// Metoda czyszcząca wartości kontrolek TextBox na formularzu
        /// </summary>
        private void ClearTextValue()
        {
            tbVin.Text = "";
            tbYearOfProduction.Text = "";
            tbBrand.Text = "";
            tbModel.Text = "";
            tbComments.Text = "";
        }   
        /// <summary>
        /// Metoda sprawdza czy wprowadzone dane są poprawnie zwalidowane oraz wywołuje metodę która dodaje obiekt do bazy danych oraz zaczytuje nowe wartości do dataGridView1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (new CarValidator(tbModel.Text, tbVin.Text, tbBrand.Text, tbYearOfProduction.Text).IsDataValid() is false)
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            carsService.Add(Convert.ToInt32(tbVin.Text), Convert.ToInt32(tbYearOfProduction.Text), tbBrand.Text, tbModel.Text, tbComments.Text,ClientId);

            ClearTextValue();
            var cars = new CarRepository().GetByClientId(ClientId);
            dataGridView1.DataSource = cars;

        }
        /// <summary>
        /// Metoda aby w polu nie było można wpisywać nic innego niż cyfry
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void tbVin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        /// <summary>
        /// Metoda aby w polu nie było można wpisywać nic innego niż cyfry
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void tbYearOfProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
        /// <summary>
        /// Metoda zamykająca formularz
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
