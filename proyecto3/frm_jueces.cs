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
    public partial class frm_jueces : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");

        public frm_jueces()
        {
            InitializeComponent();
        }

        private void frm_jueces_Load(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            this.cbx_fiscalia.DataSource = obcrud.consultar3("pr_fiscalia", "hidden= 0");
            this.cbx_fiscalia.DisplayMember = "nombre";
            this.cbx_fiscalia.ValueMember = "nombre";
            this.cbx_fiscalia.Refresh();

            this.cbx_juzgado.DataSource = obcrud.consultar3("pr_juzgado_paz", "hidden= 0");
            this.cbx_juzgado.DisplayMember = "circunscripcion";
            this.cbx_juzgado.ValueMember = "circunscripcion";
            this.cbx_juzgado.Refresh();

            mtb_buscador.Select();
            this.mtb_cedula.Enabled = false;
            this.txt_nombre.Enabled = false;
            this.txt_apellido.Enabled = false;
            this.txt_email.Enabled = false;
            this.cbx_jurisdiccion.Enabled = false;
            this.txt_telefono.Enabled = false;
            this.txt_celular.Enabled = false;
            this.cbx_juzgado.Enabled = false;
            this.cbx_fiscalia.Enabled = false;
            this.cbx_genero.Enabled = false;
            this.cbx_estado.Enabled = false;

            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre, apellido, cedula, telefono, fizcalia, juzgado, jurisdiccion from pr_jueces where hidden =0", cn);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.mtb_cedula.Enabled = true;
            this.txt_nombre.Enabled = true;
            this.txt_apellido.Enabled = true;
            this.txt_email.Enabled = true;
            this.cbx_jurisdiccion.Enabled = true;
            this.txt_telefono.Enabled = true;
            this.txt_celular.Enabled = true;
            this.cbx_juzgado.Enabled = true;
            this.cbx_fiscalia.Enabled = true;
            this.cbx_genero.Enabled = true;
            this.cbx_estado.Enabled = true;


            string cadsql = "select * from pr_jueces where cedula='" + mtb_buscador.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                mtb_cedula.Text = leer["cedula"].ToString();
                txt_nombre.Text = leer["nombre"].ToString();
                txt_apellido.Text = leer["apellido"].ToString();
                txt_email.Text = leer["email"].ToString();
                cbx_jurisdiccion.Text = leer["jurisdiccion"].ToString();
                txt_telefono.Text = leer["telefono"].ToString();
                txt_celular.Text = leer["celular"].ToString();
                cbx_juzgado.Text = leer["juzgado"].ToString();
                cbx_fiscalia.Text = leer["fizcalia"].ToString();
                cbx_genero.Text = leer["genero"].ToString();
                cbx_estado.Text = leer["estado_civil"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado");
                this.mtb_cedula.Enabled = true;
                this.mtb_cedula.Clear();
                this.txt_nombre.Enabled = true;
                this.txt_nombre.Clear();
                this.txt_apellido.Enabled = true;
                this.txt_apellido.Clear();

                this.txt_email.Enabled = true;
                this.txt_email.Clear();
                this.cbx_juzgado.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_telefono.Clear();
                this.txt_celular.Enabled = true;
                this.txt_celular.Clear();
                this.cbx_jurisdiccion.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_genero.Enabled = true;

                this.cbx_estado.Enabled = true;
                mtb_cedula.Focus();
                mtb_cedula.Select();
                con.Close();

            }
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, cedula, telefono, genero, juzgado, jurisdiccion FROM pr_jueces where cedula like ('" + mtb_buscador.Text + "%') and hidden =0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_email.Enabled = true;
                this.cbx_jurisdiccion.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.cbx_juzgado.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_genero.Enabled = true;
                this.cbx_estado.Enabled = true;


                string cadsql = "select * from pr_clientes where cedula='" + mtb_buscador.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula.Text = leer["cedula"].ToString();
                    txt_nombre.Text = leer["nombre"].ToString();
                    txt_apellido.Text = leer["apellido"].ToString();
                    txt_email.Text = leer["email"].ToString();
                    cbx_jurisdiccion.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    cbx_juzgado.Text = leer["juzgado"].ToString();
                    cbx_fiscalia.Text = leer["fizcalia"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Enabled = true;
                    this.txt_nombre.Enabled = true;
                    this.txt_apellido.Enabled = true;
                    this.txt_email.Enabled = true;
                    this.cbx_jurisdiccion.Enabled = true;
                    this.txt_telefono.Enabled = true;
                    this.txt_celular.Enabled = true;
                    this.cbx_juzgado.Enabled = true;
                    this.cbx_fiscalia.Enabled = true;
                    this.cbx_genero.Enabled = true;
                    this.cbx_estado.Enabled = true;
                    con.Close();
                    mtb_cedula.Focus();
                    mtb_cedula.Select();

                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (mtb_cedula.Text == "")
            {
                MessageBox.Show("La Cedula No Puede Ir en Blanco");
                mtb_cedula.Select();
                mtb_cedula.Focus();
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
                        if (txt_telefono.Text == "")
                        {
                            MessageBox.Show("El Telefono No Puede Ir en Blanco");
                            txt_telefono.Select();
                            txt_telefono.Focus();
                        }
                        else
                        {

                                        string sql = "insert  into pr_jueces(cedula, nombre, apellido, email, jurisdiccion, telefono, celular, juzgado, fizcalia, genero, estado_civil) values ('" + this.mtb_cedula.Text + "','" + this.txt_nombre.Text + "','" + this.txt_apellido.Text + "','" + this.txt_email.Text + "','" + this.cbx_jurisdiccion.Text + "','" + this.txt_telefono.Text + "','" + this.txt_celular.Text + "','" + this.cbx_juzgado.Text + "','" + this.cbx_fiscalia.Text + "','" + this.cbx_genero.Text + "','" + this.cbx_estado.Text + "')";
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
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (mtb_cedula.Text == "")
            {
                MessageBox.Show("La Cedula No Puede Ir en Blanco");
                mtb_cedula.Select();
                mtb_cedula.Focus();
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
                        if (txt_telefono.Text == "")
                        {
                            MessageBox.Show("El Telefono No Puede Ir en Blanco");
                            txt_telefono.Select();
                            txt_telefono.Focus();
                        }
                        else
                        {
                                        string campos = "nombre ='" + this.txt_nombre.Text + "',apellido ='" + this.txt_apellido.Text + "',email ='" + this.txt_email.Text + "',jurisdiccion ='" + this.cbx_jurisdiccion.Text + "',telefono ='" + this.txt_telefono.Text + "',celular ='" + this.txt_celular.Text + "',juzgado ='" + this.cbx_juzgado.Text + "',fizcalia ='" + this.cbx_fiscalia.Text + "',genero ='" + this.cbx_genero.Text + "',estado_civil ='" + this.cbx_estado.Text + "'";
                                        if (obcrud.actualizar("pr_jueces", campos, "cedula = '" + this.mtb_cedula.Text + "'"))
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
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            object celda;
            crud obcrud = new crud();

            celda = dataGridView2.CurrentCell.Value;

            string condicion = "nombre='" + celda + "'";
            if (obcrud.actualizar("pr_jueces", "hidden = 1", condicion))
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_ficalia fisca = new frm_add_ficalia();
            fisca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_add_juzgado juzgado = new frm_add_juzgado();
            juzgado.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_add_jurisdiccion jurisdiccion = new frm_add_jurisdiccion();
            jurisdiccion.Show();
        }

        private void mtb_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
