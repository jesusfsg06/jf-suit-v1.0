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
    public partial class frm_facturacion : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        object cell;
        string tipo;
        string datos;

        public frm_facturacion(object celda, string id, string data)
        {
           datos = data;
           tipo = id;
           cell= celda;
           InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frm_facturacion_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox2.Text = (Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox3.Text)).ToString();
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cliente= "";
            string apellido="";

            string id = tipo;
            object celda = cell;

            string data = datos;
            string campo = "";
            string campo2 = "";

            switch (id)
            {
                case "1":
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    campo = "a.nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    campo = "a.apellido";
                    campo2 = "apellido_c";
                    break;
            }

            string cadsql5 = "SELECT a.nombre, a.apellido FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where " + campo + "='" + data + "' and b.tipo='" + celda + "'";
            MySqlCommand com5 = new MySqlCommand(cadsql5, con);
            con.Open();
            MySqlDataReader leer5 = com5.ExecuteReader();
            if (leer5.Read() == true)
            {
                cliente = leer5[0].ToString();
                apellido = leer5[1].ToString();
                con.Close();
            }
            con.Close();
            crud obcrud = new crud();

            string sql = "insert  into pr_facturacion(nombre, apellido, sub_total, honorarios, itbs, notario, total, efectivo, cambio) values ('" + cliente + "','" + apellido + "','" + this.txt_sub_total.Text + "','" + this.textBox6.Text + "','" + this.textBox1.Text + "','" + this.textBox7.Text + "','" + this.textBox7.Text + "','" + this.textBox4.Text + "','" + this.textBox2.Text + "')";
            if (obcrud.insertar(sql))
            {
                MessageBox.Show("Gracias por realizar el pago");
            }
            else
            {
                MessageBox.Show("No Se ha Podido insertar");
            }

            this.Close();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox3.Text = (Convert.ToInt32(txt_sub_total.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox7.Text)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_reporte_factura fac = new frm_reporte_factura();
            frm_cotizacion cot = new frm_cotizacion();
            string id = tipo;
            object celda = cell;
           

            string data = datos;
            string campo = "";
            string campo2 = "";

            switch (id)
            {
                case "1":
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "2":
                    campo = "a.cedula";
                    campo2 = "cedula_c";
                    break;
                case "3":
                    campo = "a.nombre";
                    campo2 = "nombre_c";
                    break;
                case "4":
                    campo = "a.apellido";
                    campo2 = "apellido_c";
                    break;
            }
            //string datos = cbx_estado.SelectedItem.ToString();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT b.nombre as Gasto, b.monto as Monto, b.detalle as Detalle, a.nombre as Nombre, a.apellido as Apellido, a.cedula as Cedula, a.oficialia_civil as Oficialia FROM pr_clientes AS a INNER JOIN pr_gastos AS b ON a.client_Id = b.client_Id where a.hidden=0 and " + campo + "='" + data + "' and b.tipo = '" + celda + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            fac.dataGridView1.Visible = true;
            da.Fill(dt);
            fac.dataGridView1.DataSource = dt;

            con.Close();

            //fac.txt_sub_total.Text = txt_sub_total.Text;
            fac.textBox4.Text = textBox4.Text;
            fac.textBox3.Text = textBox3.Text;
            string info = cbx_estado.SelectedItem.ToString();
            fac.textBox5.Text = info;


            fac.Show();
        }
    }
}
