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
    public partial class rango_alquiler : Form
    {
        public rango_alquiler()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string datos = cbx_fiscalia.SelectedItem.ToString();
            reporte_alquileres f = new reporte_alquileres();
            f.label11.Text = dtp_actual.Text;
            f.label9.Text = dateTimePicker1.Text;
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre_c, apellido_c, cedula_c, nombre_i, nombre_g, alquiler, deposito from pr_alquiler where hidden =0 and actual >='" + dtp_actual.Text + "' and actual <='" + dateTimePicker1.Text + "'", cn);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp_actual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rango_alquiler_Load(object sender, EventArgs e)
        {
                        crud obcrud = new crud();

            this.cbx_fiscalia.DataSource = obcrud.consultar3("pr_clientes", "hidden= 0");
            this.cbx_fiscalia.DisplayMember = "nombre";
            this.cbx_fiscalia.ValueMember = "nombre";
            this.cbx_fiscalia.Refresh();
        }
    }
}
