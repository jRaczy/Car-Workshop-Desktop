using CarWorkShop.Infrastucture.Repositories;
using CarWorkshopDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.Forms
{
    /// <summary>
    /// Klasa odpowiadająca za warstwę logiczną formularza BasicForm
    /// </summary>
    public partial class BasicForm : Form
    {
        public int clientId;
        public int carId;
        public int visistId;
        /// <summary>
        /// Konstruktor klasy otwiera formularz 
        /// </summary>
        public BasicForm()
        {
            InitializeComponent();
        }
        /// /// <summary>
        /// Metoda zaczytująca informację do DataGridView
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void BasicForm_Load(object sender, EventArgs e)
        {
            var service = new ServiceRepository().GetAll();
            dataGridVisits.DataSource = service;
            // TODO: This line of code loads data into the 'medicarDataSet.CarVisit' table. You can move, or remove it, as needed.
           // this.carVisitTableAdapter.Fill(this.medicarDataSet.CarVisit);
            // TODO: This line of code loads data into the 'medicarDataSet.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.medicarDataSet.Car);
            // TODO: This line of code loads data into the 'medicarDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.medicarDataSet.Client);

        }
        /// /// <summary>
        /// Metoda otwierająca formularz dodawania klienta
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie </param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addClient = new AddClient();
            addClient.RefreshGrid += BasicForm_Load;
            addClient.Show();
            BasicForm_Load(sender, e);
        }
       /// <summary>
       /// Metoda odpowiada za wybór przcisku na formularzu w kolumnie i odpowiedniej akcji
       /// </summary>
       /// <param name="sender">Przycisk dodający zadanie</param>
       /// <param name="e">Event na DataGridView</param>
        private void dataGridClients_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridClients.CurrentRow.Index != -1)
            {
                var clientId = Convert.ToInt32(dataGridClients.CurrentRow.Cells[0].Value.ToString());
                var name = dataGridClients.CurrentRow.Cells[1].Value.ToString();
                var name2 = dataGridClients.CurrentRow.Cells[2].Value.ToString();
                var emailValue = dataGridClients.CurrentRow.Cells[3].Value.ToString();
                switch (e.ColumnIndex)
                {
                    case 5:
                        var editClient = new EditClient(clientId);
                        editClient.RefreshGrid += BasicForm_Load;
                        editClient.Show();
                        break;
                    case 6:
                        var previewVisit = new PreviewClient(clientId);
                        previewVisit.Show();
                        break;
                    case 7:
                        var addCar = new AddCarForm(clientId, name + " " + name2);
                        addCar.Show();
                        break;
                    case 8:
                        var sr = new ClientRepository();
                        sr.Delete(visistId);
                        break;
                    case 9:
                        var email = new Email(emailValue);
                        email.Show();
                        break;
                }
            }
        }
        /// <summary>
        /// Metoda odpowiada za wybór przcisku na formularzu w kolumnie i odpowiedniej akcji
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie</param>
        /// <param name="e">Event na DataGridView</param>
        private void dataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carId = Convert.ToInt32(dataGridCars.CurrentRow.Cells[0].Value.ToString());
            var markName = dataGridCars.CurrentRow.Cells[1].Value.ToString();
            var modelName = dataGridCars.CurrentRow.Cells[2].Value.ToString();
           
                switch (e.ColumnIndex)
                {
                    case 4:
                        var editCar = new EditCar(carId);
                        editCar.RefreshGrid += BasicForm_Load;
                        editCar.Show();
                        break;
                    case 5:
                        var previewCar = new PreviewCar(carId);
                        previewCar.Show();
                        break;
                    case 6: var addVisit = new AddVisit(carId);
                        addVisit.Show();
                        break;
                    case 7: var cr = new CarRepository();
                        cr.Delete(carId);
                    BasicForm_Load(sender, e);
                    break;
                }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BasicForm_Load(sender,e);
        }

        private void btnRefreshCar_Click(object sender, EventArgs e)
        {
            BasicForm_Load(sender, e);
        }
        /// <summary>
        /// Metoda odpowiada za wybór przcisku na formularzu w kolumnie i odpowiedniej akcji
        /// </summary>
        /// <param name="sender">Przycisk dodający zadanie</param>
        /// <param name="e">Event na DataGridView</param>
        private void dataGridVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var visitId = Convert.ToInt32(dataGridVisits.CurrentRow.Cells[0].Value.ToString());
            switch (e.ColumnIndex)
            {
                case 5:
                    var editVisit = new EditVisit(visitId);
                    editVisit.Show();
                    BasicForm_Load(sender, e);
                    break;
                case 6:
                    var previewVisit = new PreviewVisit(visitId);
                    BasicForm_Load(sender, e);
                    previewVisit.Show();
                    break;
                case 7:
                    var sr = new ServiceRepository();
                    sr.Delete(visitId);
                    BasicForm_Load(sender, e);
                    break;
            }

        }
    }
}
