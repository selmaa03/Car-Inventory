using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        private CarRepository _carRepository;
        private List<Car> carslist;
        public Form1()
        {
            InitializeComponent();
            _carRepository = new CarRepository();
            LoadCars();
        }

        private void LoadCars()
        {
            carslist = _carRepository.GetCars();
            listBoxCars.Items.Clear();
            foreach (var car in carslist)
            {
                listBoxCars.Items.Add(car);
            }

        }

        private void AddCarForm(object sender, Car car)
        {
            _carRepository.AddCar(car);
            LoadCars();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.addedcar += AddCarForm;
            addForm.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem is Car selectedCar)
            {
                _carRepository.DeleteCar(selectedCar.Id);
                LoadCars();
            }
            else
            {
                MessageBox.Show("Selection is required");
            }
        }
    }
}
