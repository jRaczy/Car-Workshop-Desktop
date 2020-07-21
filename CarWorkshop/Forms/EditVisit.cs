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
    public partial class EditVisit : Form
    {
        public int VisitId { get; set; }
        public Action<object, EventArgs> RefreshGrid;
        /// <summary>
        /// Konstruktor klasy otwiera formularz
        /// </summary>
        /// <param name="visistId"></param>
        public EditVisit(int visistId)
        {
            VisitId = visistId;
            InitializeComponent();
            InitVisist();
        }
        /// <summary>
        /// Metoda zaczytująca wartości z bazy i uzupełnia wartości pól
        /// </summary>
        private void InitVisist()
        {
            var repository = new ServiceRepository();
            var visit = repository.GetVistById(VisitId).FirstOrDefault();

            tbDescription.Text = visit.Description;
            tbPrize.Text = visit.Price.ToString();
            tbService.Text = visit.Service;
            mtbDateFrom.Text = visit.DateFrom;
            mtbDateTo.Text = visit.DateTo;
            checBoxDone.Checked =visit.IsDone;
        }
        /// <summary>
        /// /Metoda zaczytująca wartości pól i zapisująca je na bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            CarVisit visit = new CarVisit
            {
                ID=VisitId,
                Description = tbDescription.Text,
                Price = Convert.ToInt32(tbPrize.Text),
                Service = tbService.Text,
                DateFrom = mtbDateFrom.Text,
                DateTo = mtbDateTo.Text,
                IsDone = checBoxDone.Checked

            };
            var sr = new ServiceRepository();
            sr.Edit(visit);
            if (RefreshGrid != null)
                RefreshGrid(sender, e);

            this.Close();
        }
        /// <summary>
        /// Metoda zamykająca formularz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
