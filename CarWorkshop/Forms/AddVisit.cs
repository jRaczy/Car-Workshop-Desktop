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
    public partial class AddVisit : Form
    {
        bool done = false;
        public int CarId { get; set; }
        public AddVisit(int carId)
        {
            CarId = carId;
            InitializeComponent();
            var services = new ServiceRepository().GetByCarId(carId);
            dataGridView1.DataSource = services;
        }
        private void ClarTextValue()
        {
            tbDescription.Text = "";
            tbPrize.Text = "";
            tbService.Text = "";
            mtbDateFrom.Text = "";
            mtbDateTo.Text = "";
        }
        private bool AreFieldsNullOrEmpty()
        {
            if (tbDescription != null && tbPrize !=null && tbService != null && tbService != null && mtbDateTo !=null && mtbDateFrom !=null && !string.IsNullOrWhiteSpace(tbService.Text) && !string.IsNullOrWhiteSpace(tbPrize.Text) && !string.IsNullOrWhiteSpace(tbDescription.Text) && !string.IsNullOrWhiteSpace(mtbDateFrom.Text) && !string.IsNullOrWhiteSpace(mtbDateTo.Text))
            {
                return false;
            }
            return true;
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPrize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
