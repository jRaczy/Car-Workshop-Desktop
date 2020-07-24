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
    public partial class AddService : Form
    {
        public void ClearTextValue()
        {
            tbPrice.Text = "";
            tbServiceName.Text = "";
        }
        private bool AreFieldsNullOrEmpty()
        {
            if (tbPrice != null && tbServiceName!= null && !string.IsNullOrWhiteSpace(tbPrice.Text) && !string.IsNullOrWhiteSpace(tbServiceName.Text))          
            {
                return false;
            }
            return true;
        }
        public AddService()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (AreFieldsNullOrEmpty())
            {
                MessageBox.Show("Uzupełnij wszystkie pola!");
                return;
            }

            ServiceRepository sr = new ServiceRepository();
            
            ClearTextValue();
            this.Close();

        }
    }
}
