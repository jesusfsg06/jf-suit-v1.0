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
    public partial class rango_compra : Form
    {
        public rango_compra()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string datos = cbx_fiscalia.SelectedItem.ToString();

            reporte_compra f = new reporte_compra();
            f.label11.Text = dtp_actual.Text;
            f.label9.Text = dateTimePicker1.Text;
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre_c, apellido_c, cedula_c, nombre_i, nombre_g, monto, gastos from pr_compra where hidden =0 and actual >='" + dtp_actual.Text + "' and actual <='" + dateTimePicker1.Text + "' and nombre_c ='"+ datos +"'", cn);
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

        private void rango_compra_Load(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            this.cbx_fiscalia.DataSource = obcrud.consultar3("pr_clientes", "hidden= 0");
            this.cbx_fiscalia.DisplayMember = "nombre";
            this.cbx_fiscalia.ValueMember = "nombre";
            this.cbx_fiscalia.Refresh();
        }
    }
}
