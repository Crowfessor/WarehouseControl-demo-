using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseControl
{
    public partial class productz : Form
    {
        public productz()
        {
            InitializeComponent();
        }

        private void productz_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Close();
        }
    }
}
