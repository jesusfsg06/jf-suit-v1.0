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
    public partial class frm_recibo : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        public frm_recibo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_cedula_c.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = false;
            this.button9.Visible = false;
            this.button10.Visible = false;
            this.maskedTextBox1.Visible = false;
            this.textBox4.Visible = false;
            this.textBox2.Visible = false;
            lbl_id.Text = "1";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_cedula_c.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = true;
            this.button9.Visible = false;
            this.button10.Visible = false;
            this.maskedTextBox1.Visible = true;
            this.textBox4.Visible = false;
            this.textBox2.Visible = false;
            lbl_id.Text = "2";

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_cedula_c.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button9.Visible = true;
            this.button10.Visible = false;
            this.maskedTextBox1.Visible = false;
            this.textBox4.Visible = true;
            this.textBox2.Visible = false;
            lbl_id.Text = "3";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_cedula_c.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button9.Visible = false;
            this.button10.Visible = true;
            this.maskedTextBox1.Visible = false;
            this.textBox4.Visible = false;
            this.textBox2.Visible = true;
            lbl_id.Text = "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string cadsql = "select * from pr_compra where apellido_c='" + textBox2.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, monto, direccion from pr_compra where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            con.Close();

            string cadsql1 = "select * from pr_divorcios where apellido_c='" + textBox2.Text + "'";
            MySqlCommand com1 = new MySqlCommand(cadsql1, con);
            con.Open();
            MySqlDataReader leer1 = com1.ExecuteReader();
            if (leer1.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, razon, costo, abogado from pr_divorcios where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();

            string cadsql2 = "select * from pr_alquiler where apellido_c='" + textBox2.Text + "'";
            MySqlCommand com2 = new MySqlCommand(cadsql2, con);
            con.Open();
            MySqlDataReader leer2 = com2.ExecuteReader();
            if (leer2.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, alquiler, notario, direccion from pr_alquiler where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cadsql = "select * from pr_compra where nombre_c='" + textBox4.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, monto, nombre_g, nombre_i, direccion from pr_compra where hidden=0 and nombre_c='" + textBox4.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            con.Close();

            string cadsql1 = "select * from pr_divorcios where nombre_c='" + textBox4.Text + "'";
            MySqlCommand com1 = new MySqlCommand(cadsql1, con);
            con.Open();
            MySqlDataReader leer1 = com1.ExecuteReader();
            if (leer1.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, razon, costo, abogado, juez from pr_divorcios where hidden=0 and nombre_c='" + textBox4.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();

            string cadsql2 = "select * from pr_alquiler where nombre_c='" + textBox4.Text + "'";
            MySqlCommand com2 = new MySqlCommand(cadsql2, con);
            con.Open();
            MySqlDataReader leer2 = com2.ExecuteReader();
            if (leer2.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, alquiler, notario, nombre_i, direccion from pr_alquiler where hidden=0 and nombre_c='" + textBox4.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cadsql = "select * from pr_compra where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, monto, direccion from pr_compra where hidden=0 and cedula_c='" + mtb_cedula_c.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            con.Close();

            string cadsql1 = "select * from pr_divorcios where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com1 = new MySqlCommand(cadsql1, con);
            con.Open();
            MySqlDataReader leer1 = com1.ExecuteReader();
            if (leer1.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, razon, costo, abogado from pr_divorcios where hidden=0 and cedula_c='" + mtb_cedula_c.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();

            string cadsql2 = "select * from pr_alquiler where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com2 = new MySqlCommand(cadsql2, con);
            con.Open();
            MySqlDataReader leer2 = com2.ExecuteReader();
            if (leer2.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, alquiler, notario, direccion from pr_alquiler where hidden=0 and cedula_c='" + mtb_cedula_c.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_reporte_recibo rec = new frm_reporte_recibo();

            string cadsql = "select * from pr_compra where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, monto, nombre_g, nombre_i, direccion from pr_compra where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            con.Close();

            string cadsql1 = "select * from pr_divorcios where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com1 = new MySqlCommand(cadsql1, con);
            con.Open();
            MySqlDataReader leer1 = com1.ExecuteReader();
            if (leer1.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, razon, costo, abogado from pr_divorcios where hidden=0 and cedula_c='" + mtb_cedula_c.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();

            string cadsql2 = "select * from pr_alquiler where cedula_c='" + mtb_cedula_c.Text + "'";
            MySqlCommand com2 = new MySqlCommand(cadsql2, con);
            con.Open();
            MySqlDataReader leer2 = com2.ExecuteReader();
            if (leer2.Read() == true)
            {
                MySqlConnection cn;
                MySqlCommand cmd;
                MySqlDataReader dr;
                try
                {
                    cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                    cn.Open();
                    cmd = new MySqlCommand("select servicio, objeto, alquiler, notario, direccion from pr_alquiler where hidden=0 and cedula_c='" + mtb_cedula_c.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4));
                        rec.label11.Text = dr[2].ToString();
                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            con.Close();
        }

        private void frm_recibo_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_reporte_recibo rec = new frm_reporte_recibo();
            string id = lbl_id.Text;
            object celda = dataGridView1.CurrentCell.Value;
            string data = "";
            string campo = "";
            string campo2 = "";


            switch (id)
            {
                case "1":
                    data = mtb_cedula_c.Text;
                    campo = "cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    data = maskedTextBox1.Text;
                    campo = "cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    data = textBox4.Text;
                    campo = "nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    data = textBox2.Text;
                    campo = "apellido";
                    campo2 = "apellido_c";
                    break;
            }
            //string datos = cbx_estado.SelectedItem.ToString();

            string cadsql5 = "SELECT nombre, apellido from pr_clientes where " + campo + "='" + data + "' ";
            MySqlCommand com5 = new MySqlCommand(cadsql5, con);
            con.Open();
            MySqlDataReader leer5 = com5.ExecuteReader();
            if (leer5.Read() == true)
            {
                rec.label11.Text = leer5[0].ToString();
                rec.label18.Text = leer5[1].ToString();
                con.Close();
            }
            con.Close();
            con.Open();

            string cadsql4 = "SELECT SUM(b.monto)AS monto FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where " + campo + "='" + data + "' and b.tipo='" + celda + "'";
            MySqlCommand com4 = new MySqlCommand(cadsql4, con);
            MySqlDataReader leer4 = com4.ExecuteReader();
            if (leer4.Read() == true)
            {
                rec.label12.Text = leer4[0].ToString();
                con.Close();
            }
            con.Close();
            rec.Show();
        }
    }
}
