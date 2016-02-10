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
    public partial class frm_clientes : Form
    {
        imagen img = new imagen();

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        public frm_clientes()
        {
            
            InitializeComponent();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            this.cbx_fiscalia.DataSource = obcrud.consultar3("pr_fiscalia", "hidden= 0");
            this.cbx_fiscalia.DisplayMember = "nombre";
            this.cbx_fiscalia.ValueMember = "nombre";
            this.cbx_fiscalia.Refresh();

            this.cbx_procurador.DataSource = obcrud.consultar3("pr_procurador", "hidden= 0");
            this.cbx_procurador.DisplayMember = "nombre";
            this.cbx_procurador.ValueMember = "nombre";
            this.cbx_procurador.Refresh();

            this.cbx_provincia.DataSource = obcrud.consultar3("pr_provincias", "hidden= 0");
            this.cbx_provincia.DisplayMember = "nombre";
            this.cbx_provincia.ValueMember = "nombre";
            this.cbx_provincia.Refresh();

            this.cbx_sector.DataSource = obcrud.consultar3("pr_sectores", "hidden= 0");
            this.cbx_sector.DisplayMember = "nombre";
            this.cbx_sector.ValueMember = "nombre";
            this.cbx_sector.Refresh();


            this.cbx_oficialia.DataSource = obcrud.consultar3("pr_procuraduria", "hidden= 0");
            this.cbx_oficialia.DisplayMember = "nombre";
            this.cbx_oficialia.ValueMember = "nombre";
            this.cbx_oficialia.Refresh();

            mtb_buscador.Select();

            this.mtb_pasaporte.Visible = false;
            this.btn_buscar.Visible = true;
            this.maskedTextBox1.Visible = false;
            this.label21.Visible = false;
            this.mtb_cedula.Enabled = false;
            this.txt_nombre.Enabled = false;
            this.txt_apellido.Enabled = false;
            this.txt_apodo.Enabled = false;
            this.txt_email.Enabled = false;
            this.txt_contacto.Enabled = false;
            this.txt_telefono.Enabled = false;
            this.txt_celular.Enabled = false;
            this.txt_trabajo.Enabled = false;
            this.txt_direccion.Enabled = false;
            this.txt_costo.Enabled = false;
            this.txt_empresa.Enabled = false;
            this.txt_tel_emp.Enabled = false;
            this.txt_costo.Enabled = false;
            this.txt_abonos.Enabled = false;
            this.txt_direc_emp.Enabled = false;
            this.cbx_fiscalia.Enabled = false;            
            this.cbx_procurador.Enabled = false;
            this.cbx_sector.Enabled = false;
            this.cbx_provincia.Enabled = false;
            this.cbx_oficialia.Enabled = false;
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
                cmd = new MySqlCommand("select nombre, apellido, cedula, genero, telefono, direccion, trabajo_realizar, costo_servicio, fizcalia from pr_clientes where hidden=0", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));
                    
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
            this.maskedTextBox1.Enabled = true;

            this.txt_nombre.Enabled = true;
            this.txt_apellido.Enabled = true;
            this.txt_apodo.Enabled = true;
            this.txt_email.Enabled = true;
            this.txt_contacto.Enabled = true;
            this.txt_telefono.Enabled = true;
            this.txt_celular.Enabled = true;
            this.txt_trabajo.Enabled = true;
            this.txt_direccion.Enabled = true;
            this.txt_costo.Enabled = true;
            this.txt_empresa.Enabled = true;
            this.txt_tel_emp.Enabled = true;
            this.txt_costo.Enabled = true;
            this.txt_abonos.Enabled = true;
            this.txt_direc_emp.Enabled = true;
            this.cbx_fiscalia.Enabled = true;
            this.cbx_procurador.Enabled = true;
            this.cbx_sector.Enabled = true;
            this.cbx_provincia.Enabled = true;
            this.cbx_oficialia.Enabled = true;
            this.cbx_genero.Enabled = true;
            this.cbx_estado.Enabled = true;
            this.cbx_pais.Enabled = true;


            string cadsql = "select * from pr_clientes where cedula='" + mtb_buscador.Text + "'"; 
            MySqlCommand com = new MySqlCommand(cadsql,con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if(leer.Read()==true)
            {
                mtb_cedula.Text = leer["cedula"].ToString();
                txt_nombre.Text = leer["nombre"].ToString();
                txt_apellido.Text = leer["apellido"].ToString();
                txt_apodo.Text = leer["apodo"].ToString();
                txt_email.Text = leer["email"].ToString();
                txt_contacto.Text = leer["contacto"].ToString();
                txt_telefono.Text = leer["telefono"].ToString();
                txt_celular.Text = leer["celular"].ToString();
                txt_trabajo.Text = leer["trabajo_realizar"].ToString();
                txt_direccion.Text= leer["direccion"].ToString();
                txt_costo.Text = leer["costo_servicio"].ToString();
                txt_empresa.Text = leer["empresa"].ToString();
                txt_tel_emp.Text = leer["tel_trabajo"].ToString();
                txt_costo.Text = leer["costo_servicio"].ToString();
                txt_abonos.Text = leer["abonos"].ToString();
                txt_direc_emp.Text = leer["direccion_trabajo"].ToString();
                cbx_fiscalia.Text = leer["fizcalia"].ToString();
                cbx_procurador.Text = leer["procurador"].ToString();
                cbx_sector.Text = leer["sector"].ToString();
                cbx_provincia.Text = leer["provincia"].ToString();
                cbx_oficialia.Text = leer["oficialia_civil"].ToString();
                cbx_genero.Text = leer["genero"].ToString();
                cbx_estado.Text = leer["estado_civil"].ToString();
                cbx_pais.Text = leer["pais"].ToString();
                con.Close();
            }
            else
            {
            MessageBox.Show("No esta Registrado");
            this.mtb_cedula.Select();
            this.mtb_cedula.Focus();
            this.mtb_cedula.Enabled = true;
            this.maskedTextBox1.Enabled = true;

            this.txt_nombre.Enabled = true;
            this.txt_nombre.Clear();
            this.txt_apellido.Enabled = true;
            this.txt_apellido.Clear();
            this.txt_apodo.Enabled = true;
            this.txt_apodo.Clear();
            this.txt_email.Enabled = true;
            this.txt_email.Clear();
            this.txt_contacto.Enabled = true;
            this.txt_contacto.Clear();
            this.txt_telefono.Enabled = true;
            this.txt_telefono.Clear();
            this.txt_celular.Enabled = true;
            this.txt_celular.Clear();
            this.txt_trabajo.Enabled = true;
            this.txt_trabajo.Clear();
            this.txt_direccion.Enabled = true;
            this.txt_direccion.Clear();
            this.txt_costo.Enabled = true;
            this.txt_costo.Clear();
            this.txt_empresa.Enabled = true;
            this.txt_empresa.Clear();
            this.txt_tel_emp.Enabled = true;
            this.txt_tel_emp.Clear();
            this.txt_costo.Enabled = true;
            this.txt_costo.Clear();
            this.txt_abonos.Enabled = true;
            this.txt_abonos.Clear();
            this.txt_direc_emp.Enabled = true;
            this.txt_direc_emp.Clear();
            this.cbx_genero.Enabled = true;
            this.cbx_fiscalia.Enabled = true;
            this.cbx_procurador.Enabled = true;
            this.cbx_sector.Enabled = true;
            this.cbx_provincia.Enabled = true;
            this.cbx_oficialia.Enabled = true;
            this.cbx_estado.Enabled = true;
            this.cbx_pais.Enabled = true;
            con.Close();

            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula.Enabled = true;
                this.maskedTextBox1.Enabled = true;
                
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_apodo.Enabled = true;
                this.txt_email.Enabled = true;
                this.txt_contacto.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.txt_trabajo.Enabled = true;
                this.txt_direccion.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_empresa.Enabled = true;
                this.txt_tel_emp.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_direc_emp.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_sector.Enabled = true;
                this.cbx_provincia.Enabled = true;
                this.cbx_oficialia.Enabled = true;
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
                    txt_apodo.Text = leer["apodo"].ToString();
                    txt_email.Text = leer["email"].ToString();
                    txt_contacto.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    txt_trabajo.Text = leer["trabajo_realizar"].ToString();
                    txt_direccion.Text = leer["direccion"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_empresa.Text = leer["empresa"].ToString();
                    txt_tel_emp.Text = leer["tel_trabajo"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_direc_emp.Text = leer["direccion_trabajo"].ToString();
                    cbx_fiscalia.Text = leer["fizcalia"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_sector.Text = leer["sector"].ToString();
                    cbx_provincia.Text = leer["provincia"].ToString();
                    cbx_oficialia.Text = leer["oficialia_civil"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    cbx_pais.Text = leer["pais"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Select();
                    this.mtb_cedula.Focus();
                    this.mtb_cedula.Enabled = true;
                    this.maskedTextBox1.Enabled = true;

                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_apellido.Enabled = true;
                    this.txt_apellido.Clear();
                    this.txt_apodo.Enabled = true;
                    this.txt_apodo.Clear();
                    this.txt_email.Enabled = true;
                    this.txt_email.Clear();
                    this.txt_contacto.Enabled = true;
                    this.txt_contacto.Clear();
                    this.txt_telefono.Enabled = true;
                    this.txt_telefono.Clear();
                    this.txt_celular.Enabled = true;
                    this.txt_celular.Clear();
                    this.txt_trabajo.Enabled = true;
                    this.txt_trabajo.Clear();
                    this.txt_direccion.Enabled = true;
                    this.txt_direccion.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_empresa.Enabled = true;
                    this.txt_empresa.Clear();
                    this.txt_tel_emp.Enabled = true;
                    this.txt_tel_emp.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_abonos.Enabled = true;
                    this.txt_abonos.Clear();
                    this.txt_direc_emp.Enabled = true;
                    this.txt_direc_emp.Clear();
                    this.cbx_genero.Enabled = true;
                    this.cbx_fiscalia.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_sector.Enabled = true;
                    this.cbx_provincia.Enabled = true;
                    this.cbx_oficialia.Enabled = true;
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

                                if (txt_trabajo.Text == "")
                                {
                                    MessageBox.Show("El Trabajo a Realizar No Puede Ir en Blanco");
                                    txt_trabajo.Select();
                                    txt_trabajo.Focus();
                                }
                                else
                                {

                                    if (txt_costo.Text == "")
                                    {
                                        MessageBox.Show("El Costo No Puede Ir en Blanco");
                                        txt_costo.Select();
                                        txt_costo.Focus();
                                    }
                                    else
                                    {

                                        if (cbx_genero.Text == "")
                                        {
                                            MessageBox.Show("El Genero No Puede Ir en Blanco");
                                            cbx_genero.Select();
                                            cbx_genero.Focus();
                                        }
                                        else
                                        {

                                            if (cbx_estado.Text == "")
                                            {
                                                MessageBox.Show("El Estado Civil No Puede Ir en Blanco");
                                                cbx_genero.Select();
                                                cbx_genero.Focus();
                                            }
                                            else
                                            {

                                                string sql = "insert  into pr_clientes(cedula, nombre, apellido, apodo, email, contacto, telefono, celular, trabajo_realizar, direccion, costo_servicio,  empresa, abonos, direccion_trabajo, fizcalia, genero, estado_civil, pais, tel_trabajo, sector, provincia, oficialia_civil, procurador) values ('" + this.mtb_cedula.Text + "','" + this.txt_nombre.Text + "','" + this.txt_apellido.Text + "','" + this.txt_apodo.Text + "','" + this.txt_email.Text + "','" + this.txt_contacto.Text + "','" + this.txt_telefono.Text + "','" + this.txt_celular.Text + "','" + this.txt_trabajo.Text + "','" + this.txt_direccion.Text + "','" + this.txt_costo.Text + "','" + this.txt_empresa.Text + "','" + this.txt_abonos.Text + "','" + this.txt_direc_emp.Text + "','" + this.cbx_fiscalia.Text + "','" + this.cbx_genero.Text + "','" + this.cbx_estado.Text + "','" + this.cbx_pais.Text + "','" + this.txt_tel_emp.Text + "','" + this.cbx_sector.Text + "','" + this.cbx_provincia.Text + "','" + this.cbx_procurador.Text + "','" + this.cbx_oficialia.Text + "')";
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
                                    if (txt_trabajo.Text == "")
                                    {
                                        MessageBox.Show("El Trabajo a Realizar No Puede Ir en Blanco");
                                        txt_trabajo.Select();
                                        txt_trabajo.Focus();
                                    }
                                    else
                                    {

                                        string campos = "nombre ='" + this.txt_nombre.Text + "',apellido ='" + this.txt_apellido.Text + "',apodo ='" + this.txt_apodo.Text + "',email ='" + this.txt_email.Text + "',contacto ='" + this.txt_contacto.Text + "',telefono ='" + this.txt_telefono.Text + "',celular ='" + this.txt_celular.Text + "',trabajo_realizar ='" + this.txt_trabajo.Text + "',direccion ='" + this.txt_direccion.Text + "',costo_servicio ='" + this.txt_costo.Text + "',empresa ='" + this.txt_empresa.Text + "',abonos ='" + this.txt_abonos.Text + "',direccion_trabajo ='" + this.txt_direc_emp.Text + "',fizcalia ='" + this.cbx_fiscalia.Text + "',genero ='" + this.cbx_genero.Text + "',estado_civil ='" + this.cbx_estado.Text + "',pais ='" + this.cbx_pais.Text + "',tel_trabajo ='" + this.txt_tel_emp.Text + "', sector ='" + this.cbx_sector.Text + "',provincia ='" + this.cbx_provincia.Text + "',procurador ='" + this.cbx_procurador.Text + "',oficialia_civil ='" + this.cbx_oficialia.Text + "'";
                                        if (obcrud.actualizar("pr_clientes", campos, "cedula = '" + this.mtb_cedula.Text + "'"))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            object celda;
            crud obcrud = new crud();

            celda = dataGridView2.CurrentCell.Value;

            string condicion = "nombre='" + celda + "'";
            if (obcrud.actualizar("pr_clientes", "hidden = 1", condicion))
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void txt_tel_emp_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtb_buscador_TextChanged(object sender, EventArgs e)
        {
            mtb_cedula.Text = mtb_buscador.Text;
            mtb_pasaporte.Text = maskedTextBox1.Text;
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, cedula, genero, telefono, direccion, trabajo_realizar, costo_servicio, fizcalia FROM pr_clientes where cedula like ('" + mtb_buscador.Text + "%') and hidden=0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void mtb_cedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_buscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_apodo.Enabled = true;
                this.txt_email.Enabled = true;
                this.txt_contacto.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.txt_trabajo.Enabled = true;
                this.txt_direccion.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_empresa.Enabled = true;
                this.txt_tel_emp.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_direc_emp.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_sector.Enabled = true;
                this.cbx_provincia.Enabled = true;
                this.cbx_oficialia.Enabled = true;
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
                    txt_apodo.Text = leer["apodo"].ToString();
                    txt_email.Text = leer["email"].ToString();
                    txt_contacto.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    txt_trabajo.Text = leer["trabajo_realizar"].ToString();
                    txt_direccion.Text = leer["direccion"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_empresa.Text = leer["empresa"].ToString();
                    txt_tel_emp.Text = leer["tel_trabajo"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_direc_emp.Text = leer["direccion_trabajo"].ToString();
                    cbx_fiscalia.Text = leer["fizcalia"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_sector.Text = leer["sector"].ToString();
                    cbx_provincia.Text = leer["provincia"].ToString();
                    cbx_oficialia.Text = leer["oficialia_civil"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    cbx_pais.Text = leer["pais"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Select();
                    this.mtb_cedula.Focus();
                    this.mtb_cedula.Enabled = true;
                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_apellido.Enabled = true;
                    this.txt_apellido.Clear();
                    this.txt_apodo.Enabled = true;
                    this.txt_apodo.Clear();
                    this.txt_email.Enabled = true;
                    this.txt_email.Clear();
                    this.txt_contacto.Enabled = true;
                    this.txt_contacto.Clear();
                    this.txt_telefono.Enabled = true;
                    this.txt_telefono.Clear();
                    this.txt_celular.Enabled = true;
                    this.txt_celular.Clear();
                    this.txt_trabajo.Enabled = true;
                    this.txt_trabajo.Clear();
                    this.txt_direccion.Enabled = true;
                    this.txt_direccion.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_empresa.Enabled = true;
                    this.txt_empresa.Clear();
                    this.txt_tel_emp.Enabled = true;
                    this.txt_tel_emp.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_abonos.Enabled = true;
                    this.txt_abonos.Clear();
                    this.txt_direc_emp.Enabled = true;
                    this.txt_direc_emp.Clear();
                    this.cbx_genero.Enabled = true;
                    this.cbx_fiscalia.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_sector.Enabled = true;
                    this.cbx_provincia.Enabled = true;
                    this.cbx_oficialia.Enabled = true;
                    this.cbx_estado.Enabled = true;
                    this.cbx_pais.Enabled = true;
                    con.Close();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_ficalia fiscalia = new frm_add_ficalia();
            fiscalia.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_procurador procurador = new frm_procurador();
            procurador.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_add_provincia provincia = new frm_add_provincia();
            provincia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_add_sector sector = new frm_add_sector();
            sector.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_buscador.Visible = false;
            this.mtb_pasaporte.Visible = true;
            this.btn_buscar.Visible = false;
            this.button7.Visible = true;
            this.label21.Visible = true;
            this.label4.Visible = false;
            this.maskedTextBox1.Visible = true;
            mtb_pasaporte.Select();
            mtb_pasaporte.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mtb_buscador.Visible = true;
            this.mtb_pasaporte.Visible = false;
            this.btn_buscar.Visible = true;
            this.button7.Visible = false;
            this.label21.Visible = false;
            this.maskedTextBox1.Visible = false;
            this.label4.Visible = true;
            this.mtb_cedula.Visible = true;
            mtb_buscador.Focus();
            mtb_buscador.Select();

        }

        private void mtb_pasaporte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtb_pasaporte_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = mtb_pasaporte.Text;
       
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT nombre, apellido, cedula, genero, telefono, direccion, trabajo_realizar, costo_servicio, fizcalia FROM pr_clientes where pasaporte like ('" + mtb_pasaporte.Text + "%') and hidden=0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void mtb_pasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_apellido.Enabled = true;
                this.txt_apodo.Enabled = true;
                this.txt_email.Enabled = true;
                this.txt_contacto.Enabled = true;
                this.txt_telefono.Enabled = true;
                this.txt_celular.Enabled = true;
                this.txt_trabajo.Enabled = true;
                this.txt_direccion.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_empresa.Enabled = true;
                this.txt_tel_emp.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_direc_emp.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_sector.Enabled = true;
                this.cbx_provincia.Enabled = true;
                this.cbx_oficialia.Enabled = true;
                this.cbx_genero.Enabled = true;
                this.cbx_estado.Enabled = true;
                this.cbx_pais.Enabled = true;


                string cadsql = "select * from pr_clientes where pasaporte='" + mtb_pasaporte.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    mtb_cedula.Text = leer["cedula"].ToString();
                    txt_nombre.Text = leer["nombre"].ToString();
                    txt_apellido.Text = leer["apellido"].ToString();
                    txt_apodo.Text = leer["apodo"].ToString();
                    txt_email.Text = leer["email"].ToString();
                    txt_contacto.Text = leer["contacto"].ToString();
                    txt_telefono.Text = leer["telefono"].ToString();
                    txt_celular.Text = leer["celular"].ToString();
                    txt_trabajo.Text = leer["trabajo_realizar"].ToString();
                    txt_direccion.Text = leer["direccion"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_empresa.Text = leer["empresa"].ToString();
                    txt_tel_emp.Text = leer["tel_trabajo"].ToString();
                    txt_costo.Text = leer["costo_servicio"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_direc_emp.Text = leer["direccion_trabajo"].ToString();
                    cbx_fiscalia.Text = leer["fizcalia"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_sector.Text = leer["sector"].ToString();
                    cbx_provincia.Text = leer["provincia"].ToString();
                    cbx_oficialia.Text = leer["oficialia_civil"].ToString();
                    cbx_genero.Text = leer["genero"].ToString();
                    cbx_estado.Text = leer["estado_civil"].ToString();
                    cbx_pais.Text = leer["pais"].ToString();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado");
                    this.mtb_cedula.Select();
                    this.mtb_cedula.Focus();
                    this.mtb_cedula.Enabled = true;
                    this.txt_nombre.Enabled = true;
                    this.txt_nombre.Clear();
                    this.txt_apellido.Enabled = true;
                    this.txt_apellido.Clear();
                    this.txt_apodo.Enabled = true;
                    this.txt_apodo.Clear();
                    this.txt_email.Enabled = true;
                    this.txt_email.Clear();
                    this.txt_contacto.Enabled = true;
                    this.txt_contacto.Clear();
                    this.txt_telefono.Enabled = true;
                    this.txt_telefono.Clear();
                    this.txt_celular.Enabled = true;
                    this.txt_celular.Clear();
                    this.txt_trabajo.Enabled = true;
                    this.txt_trabajo.Clear();
                    this.txt_direccion.Enabled = true;
                    this.txt_direccion.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_empresa.Enabled = true;
                    this.txt_empresa.Clear();
                    this.txt_tel_emp.Enabled = true;
                    this.txt_tel_emp.Clear();
                    this.txt_costo.Enabled = true;
                    this.txt_costo.Clear();
                    this.txt_abonos.Enabled = true;
                    this.txt_abonos.Clear();
                    this.txt_direc_emp.Enabled = true;
                    this.txt_direc_emp.Clear();
                    this.cbx_genero.Enabled = true;
                    this.cbx_fiscalia.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_sector.Enabled = true;
                    this.cbx_provincia.Enabled = true;
                    this.cbx_oficialia.Enabled = true;
                    this.cbx_estado.Enabled = true;
                    this.cbx_pais.Enabled = true;
                    con.Close();

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.mtb_cedula.Enabled = true;
            this.txt_nombre.Enabled = true;
            this.txt_apellido.Enabled = true;
            this.txt_apodo.Enabled = true;
            this.txt_email.Enabled = true;
            this.txt_contacto.Enabled = true;
            this.txt_telefono.Enabled = true;
            this.txt_celular.Enabled = true;
            this.txt_trabajo.Enabled = true;
            this.txt_direccion.Enabled = true;
            this.txt_costo.Enabled = true;
            this.txt_empresa.Enabled = true;
            this.txt_tel_emp.Enabled = true;
            this.txt_costo.Enabled = true;
            this.txt_abonos.Enabled = true;
            this.txt_direc_emp.Enabled = true;
            this.cbx_fiscalia.Enabled = true;
            this.cbx_procurador.Enabled = true;
            this.cbx_sector.Enabled = true;
            this.cbx_provincia.Enabled = true;
            this.cbx_oficialia.Enabled = true;
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
                txt_apodo.Text = leer["apodo"].ToString();
                txt_email.Text = leer["email"].ToString();
                txt_contacto.Text = leer["contacto"].ToString();
                txt_telefono.Text = leer["telefono"].ToString();
                txt_celular.Text = leer["celular"].ToString();
                txt_trabajo.Text = leer["trabajo_realizar"].ToString();
                txt_direccion.Text = leer["direccion"].ToString();
                txt_costo.Text = leer["costo_servicio"].ToString();
                txt_empresa.Text = leer["empresa"].ToString();
                txt_tel_emp.Text = leer["tel_trabajo"].ToString();
                txt_costo.Text = leer["costo_servicio"].ToString();
                txt_abonos.Text = leer["abonos"].ToString();
                txt_direc_emp.Text = leer["direccion_trabajo"].ToString();
                cbx_fiscalia.Text = leer["fizcalia"].ToString();
                cbx_procurador.Text = leer["procurador"].ToString();
                cbx_sector.Text = leer["sector"].ToString();
                cbx_provincia.Text = leer["provincia"].ToString();
                cbx_oficialia.Text = leer["oficialia_civil"].ToString();
                cbx_genero.Text = leer["genero"].ToString();
                cbx_estado.Text = leer["estado_civil"].ToString();
                cbx_pais.Text = leer["pais"].ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado");
                this.mtb_cedula.Select();
                this.mtb_cedula.Focus();
                this.mtb_cedula.Enabled = true;
                this.txt_nombre.Enabled = true;
                this.txt_nombre.Clear();
                this.txt_apellido.Enabled = true;
                this.txt_apellido.Clear();
                this.txt_apodo.Enabled = true;
                this.txt_apodo.Clear();
                this.txt_email.Enabled = true;
                this.txt_email.Clear();
                this.txt_contacto.Enabled = true;
                this.txt_contacto.Clear();
                this.txt_telefono.Enabled = true;
                this.txt_telefono.Clear();
                this.txt_celular.Enabled = true;
                this.txt_celular.Clear();
                this.txt_trabajo.Enabled = true;
                this.txt_trabajo.Clear();
                this.txt_direccion.Enabled = true;
                this.txt_direccion.Clear();
                this.txt_costo.Enabled = true;
                this.txt_costo.Clear();
                this.txt_empresa.Enabled = true;
                this.txt_empresa.Clear();
                this.txt_tel_emp.Enabled = true;
                this.txt_tel_emp.Clear();
                this.txt_costo.Enabled = true;
                this.txt_costo.Clear();
                this.txt_abonos.Enabled = true;
                this.txt_abonos.Clear();
                this.txt_direc_emp.Enabled = true;
                this.txt_direc_emp.Clear();
                this.cbx_genero.Enabled = true;
                this.cbx_fiscalia.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_sector.Enabled = true;
                this.cbx_provincia.Enabled = true;
                this.cbx_oficialia.Enabled = true;
                this.cbx_estado.Enabled = true;
                this.cbx_pais.Enabled = true;
                con.Close();

            }
        }
    }
}
