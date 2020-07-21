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
    public partial class PreviewVisit : Form
    {
        public int VisitId { get; set; }
        /// <summary>
        /// Konstruktor klasy otwierający formularz
        /// </summary>
        /// <param name="visistId"></param>
        public PreviewVisit(int visistId)
        {
            VisitId = visistId;
            InitializeComponent();
            InitVisist();
        }
        /// <summary>
        /// Metoda zaczytująca wartości z bazy danych i uzupełniająca pola
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
            checBoxDone.Checked = visit.IsDone;
        }
    }
}
