using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class AddForm : Form
    {
        public event EventHandler<Car> addedcar;
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Model = textBoxMd.Text,
                Manufacture = int.Parse(textBoxMf.Text),
                Speed = int.Parse(textBoxSp.Text),
                Weight = int.Parse(textBoxWg.Text)
            };
            addedcar?.Invoke(this, car);
            Close();
        }
    }
}
