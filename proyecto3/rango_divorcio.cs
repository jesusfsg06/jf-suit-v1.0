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
    public partial class rango_divorcio : Form
    {
        public rango_divorcio()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            reporte_divorcio f = new reporte_divorcio();
            f.label11.Text = dtp_actual.Text;
            f.label9.Text = dateTimePicker1.Text;
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("SELECT cliente, abogado, juez, procurador, costo, abonos, impuestos FROM pr_divorcios where hidden =0 and date >='" + dtp_actual.Text + "' and date <='" + dateTimePicker1.Text + "'", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    f.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            f.Show();
        }
    }
}
