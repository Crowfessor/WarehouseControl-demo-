using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseControl
{
    public partial class sim : Form
    {

        

        public sim()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection("Data Source=WINZLOW;Initial Catalog=products;Integrated Security=True");







        private void button2_Click(object sender, EventArgs e)
        {

           
            this.Close();

        }


        private void sim_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
