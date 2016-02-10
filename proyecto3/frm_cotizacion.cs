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
    public partial class frm_cotizacion : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        public frm_cotizacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            frm_cotizacion cot = new frm_cotizacion();
            cot.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_cedula_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            string id = lbl_id.Text;
            string data = "";
            string campo = "";
            string campo2 = "";

            switch (id)
            { 
                case "1":
                    data = mtb_cedula_c.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    data = maskedTextBox1.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    data = textBox4.Text;
                    campo = "a.nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    data = textBox2.Text;
                    campo = "a.apellido";
                    campo2 = "apellido_c";
                    break; 
            }
            string datos = cbx_estado.SelectedItem.ToString();
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT b.nombre as Gasto, b.monto as Monto, b.detalle as Detalle, a.nombre as Nombre, a.apellido as Apellido, a.cedula as Cedula, a.oficialia_civil as Oficialia FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where a.hidden=0 and " + campo + "='" + data + "' and b.tipo = '" + datos + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
            string cadsql5 = "SELECT SUM(b.monto)AS monto FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where " + campo + "='" + data + "' and b.tipo='" + datos + "'";
            MySqlCommand com5 = new MySqlCommand(cadsql5, con);
            con.Open();
            MySqlDataReader leer5 = com5.ExecuteReader();
            if (leer5.Read() == true)
            {
                txt_sub_total.Text = leer5[0].ToString();
                con.Close();
            }
            con.Close();

            switch(datos)
            {
                case "Alquiler":
                    string cadsql2 = "select * from pr_alquiler where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                    con.Open();
                    MySqlDataReader leer2 = com2.ExecuteReader();
                    if (leer2.Read() == true)
                    {
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
                case "Compra":
                    string cadsql1 = "select * from pr_compra where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                    con.Open();
                    MySqlDataReader leer1 = com1.ExecuteReader();
                    if (leer1.Read() == true)
                    {
                        txt_sub_total.Text = leer1["monto"].ToString();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
                case "Divorcios":
                    string cadsql3 = "select * from pr_divorcios where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com3 = new MySqlCommand(cadsql3, con);
                    con.Open();
                    MySqlDataReader leer3 = com3.ExecuteReader();
                    if (leer3.Read() == true)
                    {
                        txt_sub_total.Text = leer3["costo"].ToString();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
            }
        }

        private void frm_cotizacion_Load(object sender, EventArgs e)
        {
            this.mtb_cedula_c.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = false;
            this.maskedTextBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void txt_sub_total_TextChanged(object sender, EventArgs e)
        {
           // textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(txt_sub_total.Text)).ToString(); 
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string cadsql = "select * from pr_compra where cedula_c='" + maskedTextBox1.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_estado.Items.Add("Compra");
                    con.Close();
                }
                string cadsql1 = "select * from pr_divorcios where cedula_c='" + maskedTextBox1.Text + "'";
                MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                con.Open();
                MySqlDataReader leer1 = com1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    cbx_estado.Items.Add("Divorcios");
                    con.Close();
                }
                string cadsql2 = "select * from pr_alquiler where cedula_c='" + maskedTextBox1.Text + "'";
                MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                con.Open();
                MySqlDataReader leer2 = com2.ExecuteReader();
                if (leer2.Read() == true)
                {
                    cbx_estado.Items.Add("Alquiler");
                    con.Close();
                }
            }
        }

        private void mtb_cedula_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string cadsql = "select * from pr_compra where cedula_c='" + mtb_cedula_c.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_estado.Items.Add("Compra");
                    con.Close();
                }
                string cadsql1 = "select * from pr_divorcios where cedula_c='" + mtb_cedula_c.Text + "'";
                MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                con.Open();
                MySqlDataReader leer1 = com1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    cbx_estado.Items.Add("Divorcios");
                    con.Close();
                }
                string cadsql2 = "select * from pr_alquiler where cedula_c='" + mtb_cedula_c.Text + "'";
                MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                con.Open();
                MySqlDataReader leer2 = com2.ExecuteReader();
                if (leer2.Read() == true)
                {
                    cbx_estado.Items.Add("Alquiler");
                    con.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agregado con Exito");
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(txt_sub_total.Text)).ToString();
            }

        }

        private void txt_sub_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(txt_sub_total.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object celda = dataGridView1.CurrentCell.Value;
            string id = lbl_id.Text;

            string data = "";
            string campo = "";
            string campo2 = "";

            switch (id)
            {
                case "1":
                    data = mtb_cedula_c.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";

                    break;
                case "2":
                    data = maskedTextBox1.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";

                    break;
                case "3":
                    data = textBox4.Text;
                    campo = "a.nombre";
                    campo2 = "nombre_c";

                    break;
                case "4":
                    data = textBox2.Text;
                    campo = "a.apellido";
                    campo2 = "apellido_c";

                    break;
            }
            //string datos = cbx_estado.SelectedItem.ToString();
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            frm_facturacion fac = new frm_facturacion(celda, id, data);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT b.nombre as Gasto, b.monto as Monto, b.detalle as Detalle, a.nombre as Nombre, a.apellido as Apellido, a.cedula as Cedula, a.oficialia_civil as Oficialia FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where a.hidden=0 and " + campo + "='" + data + "' and b.tipo = '" + celda + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            fac.dataGridView2.Visible = true;
            da.Fill(dt);

            fac.dataGridView2.DataSource = dt;

            con.Close();

            fac.txt_sub_total.Text = txt_sub_total.Text;
            fac.textBox1.Text = textBox1.Text;
            fac.textBox3.Text = textBox3.Text;
           // fac.textBox5.Text = label8.Text;

            fac.Show();
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
                        this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6));

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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string cadsql = "select * from pr_compra where apellido_c='" + textBox2.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_estado.Items.Add("Compra");
                    con.Close();
                }
                con.Close();

                string cadsql1 = "select * from pr_divorcios where cliente='" + textBox2.Text + "'";
                MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                con.Open();
                MySqlDataReader leer1 = com1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    cbx_estado.Items.Add("Divorcios");
                    con.Close();
                }
                con.Close();

                string cadsql2 = "select * from pr_alquiler where apellido_c='" + textBox2.Text + "'";
                MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                con.Open();
                MySqlDataReader leer2 = com2.ExecuteReader();
                if (leer2.Read() == true)
                {
                    cbx_estado.Items.Add("Alquiler");
                    con.Close();
                }
                con.Close();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string cadsql = "select * from pr_compra where nombre_c='" + textBox4.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_estado.Items.Add("Compra");
                    con.Close();
                }
                con.Close();

                string cadsql1 = "select * from pr_divorcios where nombre_c='" + textBox4.Text + "'";
                MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                con.Open();
                MySqlDataReader leer1 = com1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    cbx_estado.Items.Add("Divorcios");
                    con.Close();
                }
                con.Close();

                string cadsql2 = "select * from pr_alquiler where nombre_c='" + textBox4.Text + "'";
                MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                con.Open();
                MySqlDataReader leer2 = com2.ExecuteReader();
                if (leer2.Read() == true)
                {
                    cbx_estado.Items.Add("Alquiler");
                    con.Close();
                }
                con.Close();
            }
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
                    cmd = new MySqlCommand("select servicio, razon, costo, abogado, juez from pr_divorcios where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
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
                    cmd = new MySqlCommand("select servicio, objeto, alquiler, notario, nombre_i, direccion from pr_alquiler where hidden=0 and apellido_c='" + textBox2.Text + "'", cn);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = lbl_id.Text;
            object celda = dataGridView1.CurrentCell.Value;
            string data = "";
            string campo = "";
            string campo2 = "";

            switch (id)
            {
                case "1":
                    data = mtb_cedula_c.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    data = maskedTextBox1.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    data = textBox4.Text;
                    campo = "a.nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    data = textBox2.Text;
                    campo = "a.apellido";
                    campo2 = "apellido_c";
                    break;
            }
            //string datos = cbx_estado.SelectedItem.ToString();
            con.Open();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT b.nombre as Gasto, b.monto as Monto, b.detalle as Detalle, a.nombre as Nombre, a.apellido as Apellido, a.cedula as Cedula, a.oficialia_civil as Oficialia FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where a.hidden=0 and " + campo + "='" + data + "' and b.tipo = '" + celda + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            string cadsql5 = "SELECT SUM(b.monto)AS monto FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where " + campo + "='" + data + "' and b.tipo='" + celda + "'";
            MySqlCommand com5 = new MySqlCommand(cadsql5, con);
            con.Open();
            MySqlDataReader leer5 = com5.ExecuteReader();
            if (leer5.Read() == true)
            {
                txt_sub_total.Text = leer5[0].ToString();
                con.Close();
            }
            con.Close();

           /* switch (datos)
            {
                case "Alquiler":
                    string cadsql2 = "select * from pr_alquiler where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com2 = new MySqlCommand(cadsql2, con);
                    con.Open();
                    MySqlDataReader leer2 = com2.ExecuteReader();
                    if (leer2.Read() == true)
                    {
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
                case "Compra":
                    string cadsql1 = "select * from pr_compra where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com1 = new MySqlCommand(cadsql1, con);
                    con.Open();
                    MySqlDataReader leer1 = com1.ExecuteReader();
                    if (leer1.Read() == true)
                    {
                        txt_sub_total.Text = leer1["monto"].ToString();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
                case "Divorcios":
                    string cadsql3 = "select * from pr_divorcios where '" + campo2 + "'='" + data + "'";
                    MySqlCommand com3 = new MySqlCommand(cadsql3, con);
                    con.Open();
                    MySqlDataReader leer3 = com3.ExecuteReader();
                    if (leer3.Read() == true)
                    {
                        txt_sub_total.Text = leer3["costo"].ToString();
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                    }
                    break;
            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_reporte_cotizacion cot = new frm_reporte_cotizacion();
            string id = lbl_id.Text;
            object celda = dataGridView1.CurrentCell.Value;
            string data = "";
            string campo = "";
            string campo2 = "";

            switch (id)
            {
                case "1":
                    data = mtb_cedula_c.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    data = maskedTextBox1.Text;
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    data = textBox4.Text;
                    campo = "a.nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    data = textBox2.Text;
                    campo = "a.apellido";
                    campo2 = "apellido_c";
                    break;
            }
            //string datos = cbx_estado.SelectedItem.ToString();
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT b.nombre as Gasto, b.monto as Monto, b.detalle as Detalle, a.nombre as Nombre, a.apellido as Apellido, a.cedula as Cedula, a.oficialia_civil as Oficialia FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where a.hidden=0 and " + campo + "='" + data + "' and b.tipo = '" + celda + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            cot.dataGridView1.DataSource = dt;
            cot.Show();
            con.Close();


        }
    }
}
