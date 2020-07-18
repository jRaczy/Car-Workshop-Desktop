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
using CarWorkShop.Infrastucture.Repositories;
using CarWorkshopDomain;

namespace CarWorkshop.Forms
{
    public partial class AddCarForm : Form
    {
        public int ClientId { get; set; }
        //Konstruktor
        public AddCarForm(int clientId, string clientName)
        {
            ClientId = clientId;
            InitializeComponent();
            label1.Text += clientName;

            var cars = new CarRepository().GetByClientId(clientId);
            dataGridView1.DataSource = cars;
        }
        //Metoda do czyszczenia wartości pól textbox
        private void ClearTextValue()
        {
            tbVin.Text = "";
            tbYearOfProduction.Text = "";
            tbBrand.Text = "";
            tbModel.Text = "";
            tbComments.Text = "";
        }   
        //Metoda sprawdzająca czy wartości nie są pustę lub są nullami pól
        private bool AreFieldsNullOrEmpty()
        {
            if (tbVin != null && tbModel != null && tbBrand != null && tbYearOfProduction != null && !string.IsNullOrWhiteSpace(tbBrand.Text) && !string.IsNullOrWhiteSpace(tbModel.Text) && !string.IsNullOrWhiteSpace(tbVin.Text) && !string.IsNullOrWhiteSpace(tbYearOfProduction.Text))
            {
                return false;
            }
                return  true;
            
         }
        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (AreFieldsNullOrEmpty())
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            CarRepository cr = new CarRepository();
            cr.Add(Convert.ToInt32(tbVin.Text), Convert.ToInt32(tbYearOfProduction.Text), tbBrand.Text, tbModel.Text, tbComments.Text,ClientId);
            ClearTextValue();
            var cars = new CarRepository().GetByClientId(ClientId);
            dataGridView1.DataSource = cars;

        }
        private void tbVin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void tbYearOfProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
