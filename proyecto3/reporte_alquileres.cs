using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace proyecto3
{
    public partial class reporte_alquileres : Form
    {
        public reporte_alquileres()
        {
            InitializeComponent();
        }

        private void reporte_alquileres_Load(object sender, EventArgs e)
        {
            timer1.Start();

       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
