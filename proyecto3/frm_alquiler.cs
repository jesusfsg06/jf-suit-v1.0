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
    public partial class frm_alquiler : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");

        public frm_alquiler()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
             crud obcrud = new crud();

            if (mtb_cedula_c.Text == "")
            {
                MessageBox.Show("La Cedula del cliente No Puede Ir en Blanco");
                mtb_cedula_c.Select();
                mtb_cedula_c.Focus();
            }
            else
            {

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("El nombre del cliente No Puede Ir en Blanco");
                    comboBox1.Select();
                    comboBox1.Focus();
                }
                else
                {
                    if (txt_apellido_c.Text == "")
                    {
                        MessageBox.Show("El Apellido del cliente No Puede Ir en Blanco");
                        txt_apellido_c.Select();
                        txt_apellido_c.Focus();
                    }
                    else
                    {
                        if (cbx_genero_c.Text == "")
                        {
                            MessageBox.Show("El genero del cliente No Puede Ir en Blanco");
                            cbx_genero_c.Select();
                            cbx_genero_c.Focus();
                        }
                        else
                        {
                            if (txt_direccion_c.Text == "")
                            {
                                MessageBox.Show("La Direccion del cliente No Puede Ir en Blanco");
                                txt_direccion.Select();
                                txt_direccion.Focus();
                            }
                            else
                            {

                                if (txt_tel_c.Text == "")
                                {
                                    MessageBox.Show("El Trabajo del cliente a Realizar No Puede Ir en Blanco");
                                    txt_tel_c.Select();
                                    txt_tel_c.Focus();
                                }
                                else
                                {

                                    if (txt_celular_c.Text == "")
                                    {
                                        MessageBox.Show("El Celular del cliente No Puede Ir en Blanco");
                                        txt_celular_c.Select();
                                        txt_celular_c.Focus();
                                    }
                                        else
                                        {

                                            if (cbx_estado_civil_c.Text == "")
                                            {
                                                MessageBox.Show("El Estado Civil No Puede Ir en Blanco");
                                                cbx_estado_civil_c.Select();
                                                cbx_estado_civil_c.Focus();
                                            }
                                            else
                                            {           
                                                if (mtb_cedula_i.Text == "")
                                                    {
                                                        MessageBox.Show("La Cedula del inquilino No Puede Ir en Blanco");
                                                        mtb_cedula_i.Select();
                                                        mtb_cedula_i.Focus();
                                                    }
                                                    else
                                                    {

                                                        if (comboBox2.Text == "")
                                                        {
                                                            MessageBox.Show("El nombre del inquilino No Puede Ir en Blanco");
                                                            comboBox2.Select();
                                                            comboBox2.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (txt_apellido_i.Text == "")
                                                            {
                                                                MessageBox.Show("El Apellido del inquilino No Puede Ir en Blanco");
                                                                txt_apellido_i.Select();
                                                                txt_apellido_i.Focus();
                                                            }
                                                            else
                                                            {
                                                                if (cbx_genero_i.Text == "")
                                                                {
                                                                    MessageBox.Show("El genero del inquilino No Puede Ir en Blanco");
                                                                    cbx_genero_i.Select();
                                                                    cbx_genero_i.Focus();
                                                                }
                                                                else
                                                                {
                                                                    if (txt_direccion_i.Text == "")
                                                                    {
                                                                        MessageBox.Show("La Direccion del inquilino No Puede Ir en Blanco");
                                                                        txt_direccion_i.Select();
                                                                        txt_direccion_i.Focus();
                                                                    }
                                                                    else
                                                                    {

                                                                        if (txt_tel_i.Text == "")
                                                                        {
                                                                            MessageBox.Show("El Trabajo del inquilino a Realizar No Puede Ir en Blanco");
                                                                            txt_tel_i.Select();
                                                                            txt_tel_i.Focus();
                                                                        }
                                                                        else
                                                                        {

                                                                            if (txt_celular_i.Text == "")
                                                                            {
                                                                                MessageBox.Show("El Celular del inquilino No Puede Ir en Blanco");
                                                                                txt_celular_i.Select();
                                                                                txt_celular_i.Focus();
                                                                            }
                                                                                else
                                                                                {

                                                                                    if (cbx_estado_civil_i.Text == "")
                                                                                    {
                                                                                        MessageBox.Show("El Estado Civil del inquilino No Puede Ir en Blanco");
                                                                                        cbx_estado_civil_i.Select();
                                                                                        cbx_estado_civil_i.Focus();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                         if (mtb_cedula_g.Text == "")
                                                                                            {
                                                                                                MessageBox.Show("La Cedula del garante No Puede Ir en Blanco");
                                                                                                mtb_cedula_g.Select();
                                                                                                mtb_cedula_g.Focus();
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                if (comboBox3.Text == "")
                                                                                                {
                                                                                                    MessageBox.Show("El nombre del garante No Puede Ir en Blanco");
                                                                                                    comboBox3.Select();
                                                                                                    comboBox3.Focus();
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (txt_apellido_g.Text == "")
                                                                                                    {
                                                                                                        MessageBox.Show("El Apellido del garante No Puede Ir en Blanco");
                                                                                                        txt_apellido_g.Select();
                                                                                                        txt_apellido_g.Focus();
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (cbx_genero_g.Text == "")
                                                                                                        {
                                                                                                            MessageBox.Show("El genero del garante No Puede Ir en Blanco");
                                                                                                            cbx_genero_g.Select();
                                                                                                            cbx_genero_g.Focus();
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (txt_direccion_g.Text == "")
                                                                                                            {
                                                                                                                MessageBox.Show("La Direccion del garante No Puede Ir en Blanco");
                                                                                                                txt_direccion_g.Select();
                                                                                                                txt_direccion_g.Focus();
                                                                                                            }
                                                                                                            else
                                                                                                            {

                                                                                                                if (txt_tel_g.Text == "")
                                                                                                                {
                                                                                                                    MessageBox.Show("El Trabajo del garante a Realizar No Puede Ir en Blanco");
                                                                                                                    txt_tel_g.Select();
                                                                                                                    txt_tel_g.Focus();
                                                                                                                }
                                                                                                                else
                                                                                                                {

                                                                                                                    if (txt_celular_g.Text == "")
                                                                                                                    {
                                                                                                                        MessageBox.Show("El Celular del garante No Puede Ir en Blanco");
                                                                                                                        txt_celular_g.Select();
                                                                                                                        txt_celular_g.Focus();
                                                                                                                    }
                                                                                                                        else
                                                                                                                        {

                                                                                                                            if (cbx_estado_civil_g.Text == "")
                                                                                                                            {
                                                                                                                                MessageBox.Show("El Estado Civil del garante No Puede Ir en Blanco");
                                                                                                                                cbx_estado_civil_g.Select();
                                                                                                                                cbx_estado_civil_g.Focus();
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                string sql = "insert  into pr_alquiler(cedula_c, nombre_c, apellido_c, genero_c, telefono_c, celular_c, direccion_c, estado_civil_c, cedula_i, nombre_i, apellido_i, genero_i, telefono_i, celular_i, direccion_i, estado_civil_i, cedula_g, nombre_g, apellido_g, genero_g, telefono_g, celular_g, direccion_g, estado_civil_g, direccion, actual, contrato, alquiler, deposito, vigencia, servicio_total, servicio_mensual, notario ) values ('" + this.mtb_cedula_c.Text + "','" + this.comboBox1.Text + "', '" + this.txt_apellido_c.Text + "','" + this.cbx_genero_c.Text + "','" + this.txt_tel_c.Text + "','" + this.txt_celular_c.Text + "','" + this.txt_direccion.Text + "','" + this.cbx_estado_civil_c.Text + "','" + this.mtb_cedula_i.Text + "','" + this.comboBox2.Text + "','" + this.txt_apellido_i.Text + "','" + this.cbx_genero_i.Text + "','" + this.txt_tel_i.Text + "','" + this.txt_celular_i.Text + "','" + this.txt_direccion_i.Text + "','" + this.cbx_estado_civil_i.Text + "','" + this.mtb_cedula_g.Text + "','" + this.comboBox3.Text + "','" + this.txt_apellido_g.Text + "','" + this.cbx_genero_g.Text + "','" + this.txt_tel_g.Text + "','" + this.txt_celular_g.Text + "','" + this.txt_direccion_g.Text + "','" + this.cbx_estado_civil_g.Text + "','" + this.txt_direccion.Text + "','" + this.dtp_actual.Text + "','" + this.dtp_contrato.Text + "','" + this.txt_alquiler.Text + "','" + this.txt_deposito.Text + "','" + this.cbx_vigencia.Text + "','" + this.txt_servicio_local.Text + "','" + this.txt_servicio_mensual.Text + "','" + this.txt_notario.Text + "')";
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
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }                                                                       
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

        private void frm_alquiler_Load(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            this.comboBox1.DataSource = obcrud.consultar3("pr_clientes", "hidden= 0");
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.ValueMember = "nombre";
            this.comboBox1.Refresh();

            this.comboBox2.DataSource = obcrud.consultar3("pr_clientes", "hidden= 0");
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.ValueMember = "nombre";
            this.comboBox2.Refresh();

            this.comboBox3.DataSource = obcrud.consultar3("pr_terceros", "hidden= 0");
            this.comboBox3.DisplayMember = "nombre";
            this.comboBox3.ValueMember = "nombre";
            this.comboBox3.Refresh();

            mtb_buscador.Select();
            label1.Visible = true;
            label2.Visible = true;
            label16.Visible = true;
            label36.Visible = false;
            label37.Visible = false;
            label26.Visible = false;
            this.maskedTextBox1.Visible = false;
            this.maskedTextBox2.Visible = false;
            this.maskedTextBox3.Visible = false;
            this.mtb_cedula_c.Enabled = true;
            this.comboBox1.Enabled = false;
            this.txt_apellido_c.Enabled = false;
            this.cbx_genero_c.Enabled = false;
            this.txt_tel_c.Enabled = false;
            this.txt_celular_c.Enabled = false;
            this.txt_direccion_c.Enabled = false;
            this.cbx_estado_civil_c.Enabled = false;
            this.mtb_cedula_i.Enabled = true;
            this.comboBox2.Enabled = false;
            this.txt_apellido_i.Enabled = false;
            this.cbx_genero_i.Enabled = false;
            this.txt_tel_i.Enabled = false;
            this.txt_celular_i.Enabled = false;
            this.txt_direccion_i.Enabled = false;
            this.cbx_estado_civil_i.Enabled = false;
            this.mtb_cedula_g.Enabled = true;
            this.comboBox3.Enabled = false;
            this.txt_apellido_g.Enabled = false;
            this.cbx_genero_g.Enabled = false;
            this.txt_tel_g.Enabled = false;
            this.txt_celular_g.Enabled = false;
            this.txt_direccion_g.Enabled = false;
            this.cbx_estado_civil_g.Enabled = false; 
            
            
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select nombre_c, nombre_i, nombre_g, direccion, contrato, alquiler, notario from pr_alquiler where hidden=0", cn);
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
            this.mtb_cedula_c.Select();
            this.mtb_cedula_c.Focus();
            this.mtb_cedula_c.Enabled = true;
            this.comboBox1.Enabled = true;
            this.txt_apellido_c.Enabled = true;
            this.txt_apellido_c.Clear();
            this.cbx_genero_c.Enabled = true;
            this.txt_tel_c.Enabled = true;
            this.txt_tel_c.Clear();
            this.txt_celular_c.Enabled = true;
            this.txt_celular_c.Clear();
            this.txt_direccion_c.Enabled = true;
            this.txt_direccion_c.Clear();
            this.cbx_estado_civil_c.Enabled = true;
            this.mtb_cedula_i.Select();
            this.mtb_cedula_i.Focus();
            this.mtb_cedula_i.Enabled = true;
            this.comboBox2.Enabled = true;
            this.txt_apellido_i.Enabled = true;
            this.txt_apellido_i.Clear();
            this.cbx_genero_i.Enabled = true;
            this.txt_tel_i.Enabled = true;
            this.txt_tel_i.Clear();
            this.txt_celular_i.Enabled = true;
            this.txt_celular_i.Clear();
            this.txt_direccion_i.Enabled = true;
            this.txt_direccion_i.Clear();
            this.cbx_estado_civil_i.Enabled = true;
            this.mtb_cedula_g.Select();
            this.mtb_cedula_g.Focus();
            this.mtb_cedula_g.Enabled = true;
            this.comboBox3.Enabled = true;
            this.txt_apellido_g.Enabled = true;
            this.txt_apellido_g.Clear();
            this.cbx_genero_g.Enabled = true;
            this.txt_tel_g.Enabled = true;
            this.txt_tel_g.Clear();
            this.txt_celular_g.Enabled = true;
            this.txt_celular_g.Clear();
            this.txt_direccion_g.Enabled = true;
            this.txt_direccion_g.Clear();
            this.cbx_estado_civil_g.Enabled = true;


            string cadsql = "select * from pr_alquiler where cedula_c='" + mtb_buscador.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                mtb_cedula_c.Text = leer["cedula_c"].ToString();
                comboBox1.Text = leer["nombre_c"].ToString();
                txt_apellido_c.Text = leer["apellido_c"].ToString();
                cbx_genero_c.Text = leer["genero_c"].ToString();
                txt_tel_c.Text = leer["telefono_c"].ToString();
                txt_celular_c.Text = leer["celular_c"].ToString();
                txt_direccion_c.Text = leer["direccion_c"].ToString();
                cbx_estado_civil_c.Text = leer["estado_civil_c"].ToString();
                mtb_cedula_i.Text = leer["cedula_i"].ToString();
                comboBox2.Text = leer["nombre_i"].ToString();
                txt_apellido_i.Text = leer["apellido_i"].ToString();
                cbx_genero_i.Text = leer["genero_i"].ToString();
                txt_tel_i.Text = leer["telefono_i"].ToString();
                txt_celular_i.Text = leer["celular_i"].ToString();
                txt_direccion_i.Text = leer["direccion_i"].ToString();
                cbx_estado_civil_i.Text = leer["estado_civil_i"].ToString();
                mtb_cedula_g.Text = leer["cedula_g"].ToString();
                comboBox3.Text = leer["nombre_g"].ToString();
                txt_apellido_g.Text = leer["apellido_g"].ToString();
                cbx_genero_g.Text = leer["genero_g"].ToString();
                txt_tel_g.Text = leer["telefono_g"].ToString();
                txt_celular_g.Text = leer["celular_g"].ToString();
                txt_direccion_g.Text = leer["direccion_g"].ToString();
                cbx_estado_civil_g.Text = leer["estado_civil_g"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado");
                this.comboBox1.Select();
                this.comboBox1.Focus();
                this.mtb_cedula_c.Enabled = true;
                this.comboBox1.Enabled = true;
                this.txt_apellido_c.Enabled = true;
                this.txt_apellido_c.Clear();
                this.cbx_genero_c.Enabled = true;
                this.txt_tel_c.Enabled = true;
                this.txt_tel_c.Clear();
                this.txt_celular_c.Enabled = true;
                this.txt_celular_c.Clear();
                this.txt_direccion_c.Enabled = true;
                this.txt_direccion_c.Clear();
                this.cbx_estado_civil_c.Enabled = true;
                this.mtb_cedula_i.Select();
                this.mtb_cedula_i.Focus();
                this.mtb_cedula_i.Enabled = true;
                this.comboBox2.Enabled = true;
                this.txt_apellido_i.Enabled = true;
                this.txt_apellido_i.Clear();
                this.cbx_genero_i.Enabled = true;
                this.txt_tel_i.Enabled = true;
                this.txt_tel_i.Clear();
                this.txt_celular_i.Enabled = true;
                this.txt_celular_i.Clear();
                this.txt_direccion_i.Enabled = true;
                this.txt_direccion_i.Clear();
                this.cbx_estado_civil_i.Enabled = true;
                this.mtb_cedula_g.Select();
                this.mtb_cedula_g.Focus();
                this.mtb_cedula_g.Enabled = true;
                this.comboBox3.Enabled = true;
                this.txt_apellido_g.Enabled = true;
                this.txt_apellido_g.Clear();
                this.cbx_genero_g.Enabled = true;
                this.txt_tel_g.Enabled = true;
                this.txt_tel_g.Clear();
                this.txt_celular_g.Enabled = true;
                this.txt_celular_g.Clear();
                this.txt_direccion_g.Enabled = true;
                this.txt_direccion_g.Clear();
                this.cbx_estado_civil_g.Enabled = true;
                con.Close();

            }
        }

        private void mtb_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula_c.Select();
                this.mtb_cedula_c.Focus();
                this.mtb_cedula_c.Enabled = true;
                this.comboBox1.Enabled = true;
                this.txt_apellido_c.Enabled = true;
                this.txt_apellido_c.Clear();
                this.cbx_genero_c.Enabled = true;
                this.txt_tel_c.Enabled = true;
                this.txt_tel_c.Clear();
                this.txt_celular_c.Enabled = true;
                this.txt_celular_c.Clear();
                this.txt_direccion_c.Enabled = true;
                this.txt_direccion_c.Clear();
                this.cbx_estado_civil_c.Enabled = true;
                this.mtb_cedula_i.Select();
                this.mtb_cedula_i.Focus();
                this.mtb_cedula_i.Enabled = true;
                this.comboBox2.Enabled = true;
                this.txt_apellido_i.Enabled = true;
                this.txt_apellido_i.Clear();
                this.cbx_genero_i.Enabled = true;
                this.txt_tel_i.Enabled = true;
                this.txt_tel_i.Clear();
                this.txt_celular_i.Enabled = true;
                this.txt_celular_i.Clear();
                this.txt_direccion_i.Enabled = true;
                this.txt_direccion_i.Clear();
                this.cbx_estado_civil_i.Enabled = true;
                this.mtb_cedula_g.Select();
                this.mtb_cedula_g.Focus();
                this.mtb_cedula_g.Enabled = true;
                this.comboBox3.Enabled = true;
                this.txt_apellido_g.Enabled = true;
                this.txt_apellido_g.Clear();
                this.cbx_genero_g.Enabled = true;
                this.txt_tel_g.Enabled = true;
                this.txt_tel_g.Clear();
                this.txt_celular_g.Enabled = true;
                this.txt_celular_g.Clear();
                this.txt_direccion_g.Enabled = true;
                this.txt_direccion_g.Clear();
                this.cbx_estado_civil_g.Enabled = true;


                string cadsql = "select * from pr_alquiler where cedula_c='" + mtb_buscador.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_c.Text = leer["cedula_c"].ToString();
                    comboBox1.Text = leer["nombre_c"].ToString();
                    txt_apellido_c.Text = leer["apellido_c"].ToString();
                    cbx_genero_c.Text = leer["genero_c"].ToString();
                    txt_tel_c.Text = leer["telefono_c"].ToString();
                    txt_celular_c.Text = leer["celular_c"].ToString();
                    txt_direccion_c.Text = leer["direccion_c"].ToString();
                    cbx_estado_civil_c.Text = leer["estado_civil_c"].ToString();
                    mtb_cedula_i.Text = leer["cedula_i"].ToString();
                    comboBox2.Text = leer["nombre_i"].ToString();
                    txt_apellido_i.Text = leer["apellido_i"].ToString();
                    cbx_genero_i.Text = leer["genero_i"].ToString();
                    txt_tel_i.Text = leer["telefono_i"].ToString();
                    txt_celular_i.Text = leer["celular_i"].ToString();
                    txt_direccion_i.Text = leer["direccion_i"].ToString();
                    cbx_estado_civil_i.Text = leer["estado_civil_i"].ToString();
                    mtb_cedula_g.Text = leer["cedula_g"].ToString();
                    comboBox3.Text = leer["nombre_g"].ToString();
                    txt_apellido_g.Text = leer["apellido_g"].ToString();
                    cbx_genero_g.Text = leer["genero_g"].ToString();
                    txt_tel_g.Text = leer["telefono_g"].ToString();
                    txt_celular_g.Text = leer["celular_g"].ToString();
                    txt_direccion_g.Text = leer["direccion_g"].ToString();
                    cbx_estado_civil_g.Text = leer["estado_civil_g"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.comboBox1.Select();
                    this.comboBox1.Focus();
                    this.mtb_cedula_c.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.txt_apellido_c.Enabled = true;
                    this.txt_apellido_c.Clear();
                    this.cbx_genero_c.Enabled = true;
                    this.txt_tel_c.Enabled = true;
                    this.txt_tel_c.Clear();
                    this.txt_celular_c.Enabled = true;
                    this.txt_celular_c.Clear();
                    this.txt_direccion_c.Enabled = true;
                    this.txt_direccion_c.Clear();
                    this.cbx_estado_civil_c.Enabled = true;
                    this.mtb_cedula_i.Select();
                    this.mtb_cedula_i.Focus();
                    this.mtb_cedula_i.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.txt_apellido_i.Enabled = true;
                    this.txt_apellido_i.Clear();
                    this.cbx_genero_i.Enabled = true;
                    this.txt_tel_i.Enabled = true;
                    this.txt_tel_i.Clear();
                    this.txt_celular_i.Enabled = true;
                    this.txt_celular_i.Clear();
                    this.txt_direccion_i.Enabled = true;
                    this.txt_direccion_i.Clear();
                    this.cbx_estado_civil_i.Enabled = true;
                    this.mtb_cedula_g.Select();
                    this.mtb_cedula_g.Focus();
                    this.mtb_cedula_g.Enabled = true;
                    this.comboBox3.Enabled = true;
                    this.txt_apellido_g.Enabled = true;
                    this.txt_apellido_g.Clear();
                    this.cbx_genero_g.Enabled = true;
                    this.txt_tel_g.Enabled = true;
                    this.txt_tel_g.Clear();
                    this.txt_celular_g.Enabled = true;
                    this.txt_celular_g.Clear();
                    this.txt_direccion_g.Enabled = true;
                    this.txt_direccion_g.Clear();
                    this.cbx_estado_civil_g.Enabled = true;
                    con.Close();
                }
            }
        }

        private void mtb_buscador_TextChanged(object sender, EventArgs e)
        {
            mtb_cedula_c.Text = mtb_buscador.Text;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label16.Visible = false;
            label36.Visible = true;
            label37.Visible = true;
            label26.Visible = true;
            mtb_cedula_c.Visible = false;
            mtb_cedula_g.Visible = false;
            mtb_cedula_i.Visible = false;
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;
            maskedTextBox3.Visible = true;
            mtb_pasaporte.Visible = true;
            mtb_buscador.Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label16.Visible = true;
            label36.Visible = false;
            label37.Visible = false;
            label26.Visible = false;
            mtb_cedula_i.Visible = true;
            mtb_cedula_g.Visible = true;
            mtb_cedula_c.Visible = true;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            mtb_pasaporte.Visible = false;
            mtb_buscador.Visible = true;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula_c.Select();
                this.mtb_cedula_c.Focus();
                this.mtb_cedula_c.Enabled = true;
                this.comboBox1.Enabled = true;
                this.txt_apellido_c.Enabled = true;
                this.txt_apellido_c.Clear();
                this.cbx_genero_c.Enabled = true;
                this.txt_tel_c.Enabled = true;
                this.txt_tel_c.Clear();
                this.txt_celular_c.Enabled = true;
                this.txt_celular_c.Clear();
                this.txt_direccion_c.Enabled = true;
                this.txt_direccion_c.Clear();
                this.cbx_estado_civil_c.Enabled = true;
                
                string cadsql = "select * from pr_clientes where cedula='" + maskedTextBox1.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_c.Text = leer["cedula"].ToString();
                    comboBox1.Text = leer["nombre"].ToString();
                    txt_apellido_c.Text = leer["apellido"].ToString();
                    cbx_genero_c.Text = leer["genero"].ToString();
                    txt_tel_c.Text = leer["telefono"].ToString();
                    txt_celular_c.Text = leer["celular"].ToString();
                    txt_direccion_c.Text = leer["direccion"].ToString();
                    cbx_estado_civil_c.Text = leer["estado_civil"].ToString();
 
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.comboBox1.Select();
                    this.comboBox1.Focus();
                    this.mtb_cedula_c.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.txt_apellido_c.Enabled = true;
                    this.txt_apellido_c.Clear();
                    this.cbx_genero_c.Enabled = true;
                    this.txt_tel_c.Enabled = true;
                    this.txt_tel_c.Clear();
                    this.txt_celular_c.Enabled = true;
                    this.txt_celular_c.Clear();
                    this.txt_direccion_c.Enabled = true;
                    this.txt_direccion_c.Clear();
                    this.cbx_estado_civil_c.Enabled = true;

                    con.Close();
                }
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                this.mtb_cedula_i.Select();
                this.mtb_cedula_i.Focus();
                this.mtb_cedula_i.Enabled = true;
                this.comboBox2.Enabled = true;
                this.txt_apellido_i.Enabled = true;
                this.txt_apellido_i.Clear();
                this.cbx_genero_i.Enabled = true;
                this.txt_tel_i.Enabled = true;
                this.txt_tel_i.Clear();
                this.txt_celular_i.Enabled = true;
                this.txt_celular_i.Clear();
                this.txt_direccion_i.Enabled = true;
                this.txt_direccion_i.Clear();
                this.cbx_estado_civil_i.Enabled = true;


                string cadsql = "select * from pr_terceros where cedula='" + maskedTextBox2.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_i.Text = leer["cedula"].ToString();
                    comboBox2.Text = leer["nombre"].ToString();
                    txt_apellido_i.Text = leer["apellido"].ToString();
                    cbx_genero_i.Text = leer["genero"].ToString();
                    txt_tel_i.Text = leer["telefono"].ToString();
                    txt_celular_i.Text = leer["celular"].ToString();
                    txt_direccion_i.Text = leer["direccion"].ToString();
                    cbx_estado_civil_i.Text = leer["estado_civil"].ToString();
 
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula_i.Select();
                    this.mtb_cedula_i.Focus();
                    this.mtb_cedula_i.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.txt_apellido_i.Enabled = true;
                    this.txt_apellido_i.Clear();
                    this.cbx_genero_i.Enabled = true;
                    this.txt_tel_i.Enabled = true;
                    this.txt_tel_i.Clear();
                    this.txt_celular_i.Enabled = true;
                    this.txt_celular_i.Clear();
                    this.txt_direccion_i.Enabled = true;
                    this.txt_direccion_i.Clear();
                    this.cbx_estado_civil_i.Enabled = true;

                    con.Close();
                }
            }
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula_g.Select();
                this.mtb_cedula_g.Focus();
                this.mtb_cedula_g.Enabled = true;
                this.comboBox3.Enabled = true;
                this.txt_apellido_g.Enabled = true;
                this.txt_apellido_g.Clear();
                this.cbx_genero_g.Enabled = true;
                this.txt_tel_g.Enabled = true;
                this.txt_tel_g.Clear();
                this.txt_celular_g.Enabled = true;
                this.txt_celular_g.Clear();
                this.txt_direccion_g.Enabled = true;
                this.txt_direccion_g.Clear();
                this.cbx_estado_civil_g.Enabled = true;


                string cadsql = "select * from pr_terceros where cedula='" + maskedTextBox3.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_g.Text = leer["cedula"].ToString();
                    comboBox3.Text = leer["nombre"].ToString();
                    txt_apellido_g.Text = leer["apellido"].ToString();
                    cbx_genero_g.Text = leer["genero"].ToString();
                    txt_tel_g.Text = leer["telefono"].ToString();
                    txt_celular_g.Text = leer["celular"].ToString();
                    txt_direccion_g.Text = leer["direccion"].ToString();
                    cbx_estado_civil_g.Text = leer["estado_civil"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");

                    this.cbx_estado_civil_i.Enabled = true;
                    this.mtb_cedula_g.Select();
                    this.mtb_cedula_g.Focus();
                    this.mtb_cedula_g.Enabled = true;
                    this.comboBox3.Enabled = true;
                    this.txt_apellido_g.Enabled = true;
                    this.txt_apellido_g.Clear();
                    this.cbx_genero_g.Enabled = true;
                    this.txt_tel_g.Enabled = true;
                    this.txt_tel_g.Clear();
                    this.txt_celular_g.Enabled = true;
                    this.txt_celular_g.Clear();
                    this.txt_direccion_g.Enabled = true;
                    this.txt_direccion_g.Clear();
                    this.cbx_estado_civil_g.Enabled = true;
                    con.Close();
                }
            }
        }

        private void mtb_cedula_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula_c.Select();
                this.mtb_cedula_c.Focus();
                this.mtb_cedula_c.Enabled = true;
                this.comboBox1.Enabled = true;
                this.txt_apellido_c.Enabled = true;
                this.txt_apellido_c.Clear();
                this.cbx_genero_c.Enabled = true;
                this.txt_tel_c.Enabled = true;
                this.txt_tel_c.Clear();
                this.txt_celular_c.Enabled = true;
                this.txt_celular_c.Clear();
                this.txt_direccion_c.Enabled = true;
                this.txt_direccion_c.Clear();
                this.cbx_estado_civil_c.Enabled = true;

                string cadsql = "select * from pr_terceros where cedula='" + mtb_cedula_c.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_c.Text = leer["cedula"].ToString();
                    comboBox1.Text = leer["nombre"].ToString();
                    txt_apellido_c.Text = leer["apellido"].ToString();
                    cbx_genero_c.Text = leer["genero"].ToString();
                    txt_tel_c.Text = leer["telefono"].ToString();
                    txt_celular_c.Text = leer["celular"].ToString();
                    txt_direccion_c.Text = leer["direccion"].ToString();
                    cbx_estado_civil_c.Text = leer["estado_civil"].ToString();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.comboBox1.Select();
                    this.comboBox1.Focus();
                    this.mtb_cedula_c.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.txt_apellido_c.Enabled = true;
                    this.txt_apellido_c.Clear();
                    this.cbx_genero_c.Enabled = true;
                    this.txt_tel_c.Enabled = true;
                    this.txt_tel_c.Clear();
                    this.txt_celular_c.Enabled = true;
                    this.txt_celular_c.Clear();
                    this.txt_direccion_c.Enabled = true;
                    this.txt_direccion_c.Clear();
                    this.cbx_estado_civil_c.Enabled = true;

                    con.Close();
                }
            }
        }

        private void mtb_cedula_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                this.mtb_cedula_i.Select();
                this.mtb_cedula_i.Focus();
                this.mtb_cedula_i.Enabled = true;
                this.comboBox2.Enabled = true;
                this.txt_apellido_i.Enabled = true;
                this.txt_apellido_i.Clear();
                this.cbx_genero_i.Enabled = true;
                this.txt_tel_i.Enabled = true;
                this.txt_tel_i.Clear();
                this.txt_celular_i.Enabled = true;
                this.txt_celular_i.Clear();
                this.txt_direccion_i.Enabled = true;
                this.txt_direccion_i.Clear();
                this.cbx_estado_civil_i.Enabled = true;


                string cadsql = "select * from pr_terceros where cedula='" + txt_celular_i + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_i.Text = leer["cedula"].ToString();
                    comboBox2.Text = leer["nombre"].ToString();
                    txt_apellido_i.Text = leer["apellido"].ToString();
                    cbx_genero_i.Text = leer["genero"].ToString();
                    txt_tel_i.Text = leer["telefono"].ToString();
                    txt_celular_i.Text = leer["celular"].ToString();
                    txt_direccion_i.Text = leer["direccion"].ToString();
                    cbx_estado_civil_i.Text = leer["estado_civil"].ToString();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula_i.Select();
                    this.mtb_cedula_i.Focus();
                    this.mtb_cedula_i.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.txt_apellido_i.Enabled = true;
                    this.txt_apellido_i.Clear();
                    this.cbx_genero_i.Enabled = true;
                    this.txt_tel_i.Enabled = true;
                    this.txt_tel_i.Clear();
                    this.txt_celular_i.Enabled = true;
                    this.txt_celular_i.Clear();
                    this.txt_direccion_i.Enabled = true;
                    this.txt_direccion_i.Clear();
                    this.cbx_estado_civil_i.Enabled = true;

                    con.Close();
                }
            }
        }

        private void mtb_cedula_g_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_cedula_g_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula_g.Select();
                this.mtb_cedula_g.Focus();
                this.mtb_cedula_g.Enabled = true;
                this.comboBox3.Enabled = true;
                this.txt_apellido_g.Enabled = true;
                this.txt_apellido_g.Clear();
                this.cbx_genero_g.Enabled = true;
                this.txt_tel_g.Enabled = true;
                this.txt_tel_g.Clear();
                this.txt_celular_g.Enabled = true;
                this.txt_celular_g.Clear();
                this.txt_direccion_g.Enabled = true;
                this.txt_direccion_g.Clear();
                this.cbx_estado_civil_g.Enabled = true;


                string cadsql = "select * from pr_terceros where cedula='" + mtb_cedula_g.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula_g.Text = leer["cedula"].ToString();
                    comboBox3.Text = leer["nombre"].ToString();
                    txt_apellido_g.Text = leer["apellido"].ToString();
                    cbx_genero_g.Text = leer["genero"].ToString();
                    txt_tel_g.Text = leer["telefono"].ToString();
                    txt_celular_g.Text = leer["celular"].ToString();
                    txt_direccion_g.Text = leer["direccion"].ToString();
                    cbx_estado_civil_g.Text = leer["estado_civil"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");

                    this.cbx_estado_civil_i.Enabled = true;
                    this.mtb_cedula_g.Select();
                    this.mtb_cedula_g.Focus();
                    this.mtb_cedula_g.Enabled = true;
                    this.comboBox3.Enabled = true;
                    this.txt_apellido_g.Enabled = true;
                    this.txt_apellido_g.Clear();
                    this.cbx_genero_g.Enabled = true;
                    this.txt_tel_g.Enabled = true;
                    this.txt_tel_g.Clear();
                    this.txt_celular_g.Enabled = true;
                    this.txt_celular_g.Clear();
                    this.txt_direccion_g.Enabled = true;
                    this.txt_direccion_g.Clear();
                    this.cbx_estado_civil_g.Enabled = true;
                    con.Close();
                }
            }
        }

        private void mtb_pasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mtb_cedula_c_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_cedula_i_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rango_alquiler alquiler = new rango_alquiler();
            alquiler.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_clientes cli = new frm_clientes();
            cli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_terceros ter = new frm_terceros();
            ter.Show();
        }                          
    }
}
                    
