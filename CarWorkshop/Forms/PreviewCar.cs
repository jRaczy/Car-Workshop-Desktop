﻿using CarWorkShop.Infrastucture.Repositories;
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
    public partial class PreviewCar : Form
    {
        public int CarId { get; set; }
        /// <summary>
        /// Konstruktor klasy otwierający formularz
        /// </summary>
        /// <param name="carId"></param>
        public PreviewCar(int carId)
        {
            CarId = carId;
            InitializeComponent();
            InitCar();
        }
        /// <summary>
        /// Metoda zaczytująca wartości z bazy danych i uzupełniająca pola
        /// </summary>
        private void InitCar()
        {
            var cr = new CarRepository();
            var clients = cr.GetCarById(CarId).FirstOrDefault();

            tbBrand.Text = clients.Brand;
            tbComments.Text = clients.Comments;
            tbModel.Text = clients.Model;
            tbVin.Text = clients.VIN.ToString();
            tbYearOfProduction.Text = clients.YearOfProduction.ToString();
        }
    }
}
