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
    public partial class frm_abogados : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        public frm_abogados()
        {
            InitializeComponent();
        }

        private void frm_abogados_Load(object sender, EventArgs e)
        {
            mtb_buscador.Select();
            this.mtb_cedula.Enabled = false;
            this.txt_nombre.Enabled = false;
            this.txt_apellido.Enabled = false;
            this.txt_email.Enabled = false;
            this.txt_contacto.Enabled = false;
            this.txt_telefono.Enabled = false;
            this.txt_celular.Enabled = false;
            this.txt_direccion.Enabled = false;
            this.txt_fizcalia.Enabled = false;
            this.cbx_genero.Enabled = false;
            this.cbx_estado.Enabled = false;
            this.cbx_pais.Enabled = false;

            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre, apellido, cedula, telefono, direccion, fizcalia from pr_abogados where hidden =0", cn);
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.mtb_cedula.Enabled = true;
            this.txt_nombre.Enabled = true;
            this.txt_apellido.Enabled = true;
            this.txt_email.Enabled = true;
            this.txt_contacto.Enabled = true;
            this.txt_telefono.Enabled = true;
            this.txt_celular.Enabled = true;
            this.txt_direccion.Enabled = true;
            this.txt_fizcalia.Enabled = true;
            this.cbx_genero.Enabled = true;
            this.cbx_estado.Enabled = true;
            this.cbx_pais.Enabled = true;


            string cadsql = "select * from pr_abogados where cedula='" + mtb_buscador.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                mtb_cedula.Text = leer["cedula"].ToString();
                txt_nombre.Text = leer["nombre"].ToString();
                txt_apellido.Text = leer["apellido"].ToString();
                txt_email.Text = leer["email"].ToString();
                txt_contacto.Text = leer["contacto"].ToString();
                txt_telefono.Text = leer["telefono"].ToString();
                txt_celular.Text = leer["celular"].ToString();
                txt_direccion.Text = leer["direccion"].ToString();
                txt_fizcalia.Text = leer["fizcalia"].ToString();
                cbx_genero.Text = leer["genero"].ToString();
                cbx_estado.Text = leer["estado_civil"].ToString();
                cbx_pais.Text = leer["pais"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado");

                this.mtb_cedula.Enabled = true;

                this.txt_nombre.Enabled = true;
                this.txt_nombre.Clear();
                this.txt_apellido.Enabled = true;
                this.txt_apellido.Clear();

                this.txt_email.Enabled = true;
                this.txt_email.Clear();
                this.txt_contacto.Enabled = true;
                this.txt_contacto.Clear();
                this.txt_telefono.Enabled = true;
                this.txt_telefono.Clear();
                this.txt_celular.Enabled = true;
                this.txt_celular.Clear();
                this.txt_direccion.Enabled = true;
                this.txt_direccion.Clear();
                this.txt_fizcalia.Enabled = true;
                this.txt_fizcalia.Clear();
                this.cbx_genero.Enabled = true;

                this.cbx_estado.Enabled = true;
                this.cbx_pais.Enabled = true;
                con.Close();

            }
        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_email.Enabled = true;
                this.txt_contacto.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.txt_direccion.Enabled = true;
                this.txt_fizcalia.Enabled = true;
                this.cbx_genero.Enabled = true;
                this.cbx_estado.Enabled = true;
                this.cbx_pais.Enabled = true;


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
                    txt_contacto.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    txt_direccion.Text = leer["direccion"].ToString();
                    txt_fizcalia.Text = leer["fizcalia"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    cbx_pais.Text = leer["pais"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Enabled = true;
                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_nombre.Select();
                    this.txt_nombre.Focus();
                    this.txt_apellido.Enabled = true;
                    this.txt_apellido.Clear();
                    this.txt_email.Enabled = true;
                    this.txt_email.Clear();
                    this.txt_contacto.Enabled = true;
                    this.txt_contacto.Clear();
                    this.txt_telefono.Enabled = true;
                    this.txt_telefono.Clear();
                    this.txt_celular.Enabled = true;
                    this.txt_celular.Clear();
                    this.txt_direccion.Enabled = true;
                    this.txt_direccion.Clear();
                    this.txt_fizcalia.Enabled = true;
                    this.txt_fizcalia.Clear();
                    this.cbx_genero.Enabled = true;
                    this.cbx_estado.Enabled = true;
                    this.cbx_pais.Enabled = true;
                    con.Close();

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
                            if (txt_direccion.Text == "")
                            {
                                MessageBox.Show("La Direccion No Puede Ir en Blanco");
                                txt_direccion.Select();
                                txt_direccion.Focus();
                            }
                            else
                            {
                                {
                                    if (txt_fizcalia.Text == "")
                                    {
                                        MessageBox.Show("La Fizcalia No Puede Ir en Blanco");
                                        txt_fizcalia.Select();
                                        txt_fizcalia.Focus();
                                    }
                                    else
                                    {
                                        string sql = "insert  into pr_abogados(cedula, nombre, apellido, email, contacto, telefono, celular, direccion, fizcalia, genero, estado_civil, pais) values ('" + this.mtb_cedula.Text + "','" + this.txt_nombre.Text + "','" + this.txt_apellido.Text + "','" + this.txt_email.Text + "','" + this.txt_contacto.Text + "','" + this.txt_telefono.Text + "','" + this.txt_celular.Text + "','" + this.txt_direccion.Text + "','" + this.txt_fizcalia.Text + "','" + this.cbx_genero.Text + "','" + this.cbx_estado.Text + "','" + this.cbx_pais.Text + "')";
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
                            if (txt_direccion.Text == "")
                            {
                                MessageBox.Show("La Direccion No Puede Ir en Blanco");
                                txt_direccion.Select();
                                txt_direccion.Focus();
                            }
                            else
                            {
                                {
                                    if (txt_fizcalia.Text == "")
                                    {
                                        MessageBox.Show("El Trabajo a Realizar No Puede Ir en Blanco");
                                        txt_fizcalia.Select();
                                        txt_fizcalia.Focus();
                                    }
                                    else
                                    {

                                        string campos = "nombre ='" + this.txt_nombre.Text + "',apellido ='" + this.txt_apellido.Text + "',email ='" + this.txt_email.Text + "',contacto ='" + this.txt_contacto.Text + "',telefono ='" + this.txt_telefono.Text + "',celular ='" + this.txt_celular.Text + "',direccion ='" + this.txt_direccion.Text + "',fizcalia ='" + this.txt_fizcalia.Text + "',genero ='" + this.cbx_genero.Text + "',estado_civil ='" + this.cbx_estado.Text + "',pais ='" + this.cbx_pais.Text + "'";
                                        if (obcrud.actualizar("pr_abogados", campos, "cedula = '" + this.mtb_cedula.Text + "'"))
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
                }
            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            object celda;
            crud obcrud = new crud();

            celda = dataGridView2.CurrentCell.Value;

            string condicion = "nombre='" + celda + "'";
            if (obcrud.actualizar("pr_abogados", "hidden = 1", condicion))
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

        private void mtb_buscador_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_buscador_TextChanged(object sender, EventArgs e)
        {
            mtb_cedula.Text = mtb_buscador.Text;

            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, cedula, telefono, genero, direccion, fizcalia FROM pr_abogados where cedula like ('" + mtb_buscador.Text + "%') and hidden =0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void mtb_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_email.Enabled = true;
                this.txt_contacto.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.txt_direccion.Enabled = true;
                this.txt_fizcalia.Enabled = true;
                this.cbx_genero.Enabled = true;
                this.cbx_estado.Enabled = true;
                this.cbx_pais.Enabled = true;


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
                    txt_contacto.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    txt_direccion.Text = leer["direccion"].ToString();
                    txt_fizcalia.Text = leer["fizcalia"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    cbx_pais.Text = leer["pais"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Enabled = true;
                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_nombre.Select();
                    this.txt_nombre.Focus();
                    this.txt_apellido.Enabled = true;
                    this.txt_email.Enabled = true;
                    this.txt_contacto.Enabled = true;
                    this.txt_telefono.Enabled = true;
                    this.txt_celular.Enabled = true;
                    this.txt_direccion.Enabled = true;
                    this.txt_fizcalia.Enabled = true;
                    this.cbx_genero.Enabled = true;
                    this.cbx_estado.Enabled = true;
                    this.cbx_pais.Enabled = true;
                    con.Close();

                }
            }
        }
    }
}
