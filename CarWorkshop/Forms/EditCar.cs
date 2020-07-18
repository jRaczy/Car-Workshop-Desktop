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
using CarWorkShop.Infrastucture.Repositories;

namespace CarWorkshop.Forms
{
    public partial class EditCar : Form
    {
        public int CarId { get; set; }
        public Action<object, EventArgs> RefreshGrid;
        public EditCar(int carId)
        {
            CarId = carId;
            InitializeComponent();
            InitCars();
        }
        //Metoda zaczytuje wartości z bazy dla danego obiektu i uzupełnia nimi pola
        private void InitCars()
        {
            var repository = new CarRepository();
            var car = repository.GetCarById(CarId).FirstOrDefault();

            tbVin.Text = car.VIN.ToString();
            tbYearOfProduction.Text = car.YearOfProduction.ToString();
            tbBrand.Text = car.Brand;
            tbModel.Text = car.Model;
            tbComments.Text = car.Comments;
        }
        //Event podczas którego zapisywane są wartości z pól i przekazywane do bazy
        private void btnAccept_Click(object sender, EventArgs e)
        {
                Car car = new Car
                {
                    Id = CarId,
                    Model = tbModel.Text,
                    Brand = tbBrand.Text,
                    VIN = Convert.ToInt32(tbVin.Text),
                    Comments = tbComments.Text,
                    YearOfProduction = Convert.ToInt32(tbYearOfProduction.Text)
                };
                var cr = new CarRepository();
                cr.Edit(car);
                if (RefreshGrid != null)
                    RefreshGrid(sender, e);

                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               private void tbVin_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void tbYearOfProduction_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
