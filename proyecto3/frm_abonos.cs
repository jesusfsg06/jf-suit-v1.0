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
    public partial class frm_abonos : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");

        public frm_abonos()
        {
            InitializeComponent();
        }

        private void frm_abonos_Load(object sender, EventArgs e)
        {
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;
            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select id, nombre, apellido, sub_total, honorarios, itbs, notario, total, efectivo, cambio from pr_facturacion where cambio <= '1'", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.dataGridView2.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9));

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }    
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object celda = dataGridView2.CurrentCell.Value;

            string cadsql5 = "SELECT cambio FROM pr_facturacion where id='" + celda + "'";
            MySqlCommand com5 = new MySqlCommand(cadsql5, con);
            con.Open();
            MySqlDataReader leer5 = com5.ExecuteReader();
            if (leer5.Read() == true)
            {
                textBox4.Text = leer5[0].ToString();
                con.Close();
            }
            con.Close();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox1.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crud obcrud = new crud();
            object celda = dataGridView2.CurrentCell.Value;
            string campos = "cambio ='" + this.textBox1.Text + "'";
            if (obcrud.actualizar("pr_facturacion", campos, "id = '" + celda + "'"))
            {
                MessageBox.Show("Se a Actualizado Correctamente");
                dataGridView2.Rows.Clear();
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select id, nombre, apellido, sub_total, honorarios, itbs, notario, total, efectivo, cambio from pr_facturacion where cambio <= '0'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView2.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }   
            }
            else
            {
                MessageBox.Show("no se pudo actualizar");
            }
        }
    }
}
