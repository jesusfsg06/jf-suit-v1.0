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
    public partial class frm_procurador : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        crud obcrud = new crud();

        public frm_procurador()
        {
            InitializeComponent();
        }

        private void frm_procurador_Load(object sender, EventArgs e)
        {
            this.cbx_procuraduria.DataSource = obcrud.consultar3("pr_procuraduria", "hidden= 0");
            this.cbx_procuraduria.DisplayMember = "nombre";
            this.cbx_procuraduria.ValueMember = "nombre";
            this.cbx_procuraduria.Refresh();

             txt_buscador.Select();
            this.txt_cedula.Enabled = false;
            this.txt_nombre.Enabled = false;
            this.txt_apellido.Enabled = false;
            this.cbx_genero.Enabled = false;

            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre, apellido, cedula, tipo_procurador, procu_id from pr_procurador where hidden =0", cn);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
   
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
        }

        private void txt_buscador_TextChanged_1(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, cedula, tipo_procurador, procu_id FROM pr_procurador where cedula like ('" + txt_buscador.Text + "%') and hidden =0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            this.txt_cedula.Enabled = true;
            this.txt_nombre.Enabled = true;
            this.txt_apellido.Enabled = true;
            this.cbx_genero.Enabled = true;
            this.cbx_procu_type.Enabled = true;
            this.cbx_procuraduria.Enabled = true;


            string cadsql = "select * from pr_procurador where cedula='" + txt_buscador.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                txt_cedula.Text = leer["cedula"].ToString();
                txt_nombre.Text = leer["nombre"].ToString();
                txt_apellido.Text = leer["apellido"].ToString();
                cbx_genero.Text = leer["genero"].ToString();
                cbx_procu_type.Text = leer["tipo_procurador"].ToString();
                cbx_procuraduria.Text = leer["procu_id"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado");
                this.txt_cedula.Enabled = true;
                this.txt_cedula.Clear();
                this.txt_nombre.Enabled = true;
                this.txt_nombre.Clear();
                this.txt_apellido.Enabled = true;
                this.txt_apellido.Clear();
                this.cbx_genero.Enabled = true;
                this.cbx_procu_type.Enabled = true;
                this.cbx_procuraduria.Enabled = true;

                con.Close();
            }
        }

        private void txt_buscador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.txt_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.cbx_genero.Enabled = true;
                this.cbx_procu_type.Enabled = true;
                this.cbx_procuraduria.Enabled = true;


                string cadsql = "select * from pr_procurador where cedula='" + txt_buscador.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    txt_cedula.Text = leer["cedula"].ToString();
                    txt_nombre.Text = leer["nombre"].ToString();
                    txt_apellido.Text = leer["apellido"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_procu_type.Text = leer["tipo_procurador"].ToString();
                    cbx_procuraduria.Text = leer["procu_id"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.txt_cedula.Enabled = true;
                    this.txt_cedula.Clear();
                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_apellido.Enabled = true;
                    this.txt_apellido.Clear();
                    this.cbx_genero.Enabled = true;
                    this.cbx_procu_type.Enabled = true;
                    this.cbx_procuraduria.Enabled = true;

                    con.Close();
                }
            }
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (txt_cedula.Text == "")
            {
                MessageBox.Show("La Cedula No Puede Ir en Blanco");
                txt_cedula.Select();
                txt_cedula.Focus();
            }
            else
            {

                if (txt_nombre.Text == "")
                {
                    MessageBox.Show("El nombre No Puede Ir en Blanco");
                    txt_nombre.Select();
                    txt_nombre.Focus();
                }
                else
                {
                    if (txt_apellido.Text == "")
                    {
                        MessageBox.Show("El Apellido No Puede Ir en Blanco");
                        txt_apellido.Select();
                        txt_apellido.Focus();
                    }
                    else
                    {

                        string sql = "insert  into pr_procurador (cedula, nombre, apellido, genero, tipo_procurador, procu_id) values ('" + this.txt_cedula.Text + "','" + this.txt_nombre.Text + "','" + this.txt_apellido.Text + "','" + this.cbx_genero.Text + "','" + this.cbx_procu_type.Text + "','" + this.cbx_procuraduria.Text + "')";
                        if (obcrud.insertar(sql))
                        {
                            MessageBox.Show("Se ha agregado Correctamente");
                            dataGridView1.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("No Se ha Podido insertar");
                        }
                    }
                }
            }
     
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (txt_cedula.Text == "")
            {
                MessageBox.Show("La Cedula No Puede Ir en Blanco");
                txt_cedula.Select();
                txt_cedula.Focus();
            }
            else
            {

                if (txt_nombre.Text == "")
                {
                    MessageBox.Show("El nombre No Puede Ir en Blanco");
                    txt_nombre.Select();
                    txt_nombre.Focus();
                }
                else
                {
                    if (txt_apellido.Text == "")
                    {
                        MessageBox.Show("El Apellido No Puede Ir en Blanco");
                        txt_apellido.Select();
                        txt_apellido.Focus();
                    }
                    else
                    {
                        string campos = "nombre ='" + this.txt_nombre.Text + "',apellido ='" + this.txt_apellido.Text + "',genero ='" + this.cbx_genero.Text + "',tipo_procurador ='" + this.cbx_procu_type.Text + "',procu_id ='" + this.cbx_procuraduria.Text + "'";
                        if (obcrud.actualizar("pr_procurador", campos, "cedula = '" + this.txt_cedula.Text + "'"))
                        {
                            MessageBox.Show("Se a Actualizado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("no se pudo actualizar");
                        }
                    }
                }
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            object celda;
            crud obcrud = new crud();

            celda = dataGridView2.CurrentCell.Value;

            string condicion = "nombre='" + celda + "'";
            if (obcrud.actualizar("pr_procurador", "hidden = 1", condicion))
            {
                dataGridView2.Refresh();
                int fill = dataGridView2.CurrentRow.Index;
                dataGridView2.Rows.RemoveAt(fill);
            }
            else
            {
                MessageBox.Show("No Se ha Podido Eliminar, correctamente. Debe seleccionar el nombre y luego darle a Eliminar.");
            }
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
