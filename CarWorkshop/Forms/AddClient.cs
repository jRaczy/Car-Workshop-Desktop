using CarWorkshop.Forms.Enums;
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
    public partial class AddClient : Form
    {
        public ModeView Mode { get; set; }
        public Client Client { get; set; }
        
        public Action<object, EventArgs> RefreshGrid;
        //Konstruktor
        public AddClient()
        {
            InitializeComponent();
        }
        
        public void InitControls(Client client)
        {
            tbName.Text = client.Name;
        }
        //Metoda ustawiająca edycje pola
        public void DisableControls()
        {
            tbName.Enabled = false;
        }
        //Metoda czyszcząca wartości pól
        public void ClearTextValue()
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbPhoneNumber.Text="";
            tbSurname.Text="";
        }
        //Metoda sprawdzająca czy pola nie są pustę lub sa nullami
        private bool AreFieldsNullOrEmpty()
        {
            if (tbAddress != null && tbEmail != null && tbName != null && tbPhoneNumber != null && tbSurname!=null && !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                !string.IsNullOrWhiteSpace(tbEmail.Text) && !string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbPhoneNumber.Text)&& !string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                return false;
            }
            return true;

        }

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

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
