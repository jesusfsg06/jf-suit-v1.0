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
    public partial class frm_divorcio : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
        crud obcrud = new crud();

        public frm_divorcio()
        {
            InitializeComponent();
        }

        private void frm_divorcio_Load(object sender, EventArgs e)
        {
            this.cbx_cliente.DataSource = obcrud.consultar3("pr_clientes", "hidden= 0");
            this.cbx_cliente.DisplayMember = "nombre";
            this.cbx_cliente.ValueMember = "nombre";
            this.cbx_cliente.Refresh();

            this.cbx_abogado.DataSource = obcrud.consultar3("pr_abogados", "hidden= 0");
            this.cbx_abogado.DisplayMember = "nombre";
            this.cbx_abogado.ValueMember = "nombre";
            this.cbx_abogado.Refresh();

            this.cbx_juez.DataSource = obcrud.consultar3("pr_jueces", "hidden= 0");
            this.cbx_juez.DisplayMember = "nombre";
            this.cbx_juez.ValueMember = "nombre";
            this.cbx_juez.Refresh();

            this.cbx_procurador.DataSource = obcrud.consultar3("pr_procurador", "hidden= 0");
            this.cbx_procurador.DisplayMember = "nombre";
            this.cbx_procurador.ValueMember = "nombre";
            this.cbx_procurador.Refresh();

            maskedTextBox1.Select();
            this.cbx_cliente.Enabled = false;
            this.cbx_abogado.Enabled = false;
            this.cbx_juez.Enabled = false;
            this.cbx_procurador.Enabled = false;
            this.cbx_razon.Enabled = false;
            this.txt_costo.Enabled = false;
            this.txt_abonos.Enabled = false;
            this.txt_impuesto.Enabled = false;
            this.richTextBox1.Enabled = false;

            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto3; password=");
                cn.Open();
                cmd = new MySqlCommand("select cliente, abogado, juez, procurador, razon, costo, abonos, impuestos, notas from pr_divorcios where hidden = 0", cn);
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

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cliente, abogado, juez, procurador, razon, costo, abonos, impuestos, notas  FROM pr_divorcios where cliente like ('" + maskedTextBox1.Text + "%') and hidden =0";
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
                this.cbx_cliente.Enabled = true;
                this.cbx_abogado.Enabled = true;
                this.cbx_juez.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_razon.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_impuesto.Enabled = true;
                this.richTextBox1.Enabled = true;


                string cadsql = "select * from pr_divorcios where cliente='" + maskedTextBox1.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_cliente.Text = leer["cliente"].ToString();
                    cbx_abogado.Text = leer["abogado"].ToString();
                    cbx_juez.Text = leer["juez"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_razon.Text = leer["razon"].ToString();
                    txt_costo.Text = leer["costo"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_impuesto.Text = leer["impuestos"].ToString();
                    richTextBox1.Text = leer["notas"].ToString();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado, Puede Procesar el Divorcio");
                    this.cbx_cliente.Select();
                    this.cbx_cliente.Enabled = true;
                    this.cbx_abogado.Enabled = true;
                    this.cbx_juez.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_razon.Enabled = true;
                    this.txt_costo.Enabled = true;
                    this.txt_abonos.Enabled = true;
                    this.txt_impuesto.Enabled = true;
                    this.richTextBox1.Enabled = true;

                    con.Close();
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.cbx_cliente.Enabled = true;
            this.cbx_abogado.Enabled = true;
            this.cbx_juez.Enabled = true;
            this.cbx_procurador.Enabled = true;
            this.cbx_razon.Enabled = true;
            this.txt_costo.Enabled = true;
            this.txt_abonos.Enabled = true;
            this.txt_impuesto.Enabled = true;
            this.richTextBox1.Enabled = true;


            string cadsql = "select * from pr_divorcios where cedula='" + maskedTextBox1.Text + "'";
            MySqlCommand com = new MySqlCommand(cadsql, con);
            con.Open();
            MySqlDataReader leer = com.ExecuteReader();
            if (leer.Read() == true)
            {
                cbx_cliente.Text = leer["cliente"].ToString();
                cbx_abogado.Text = leer["abogado"].ToString();
                cbx_juez.Text = leer["juez"].ToString();
                cbx_procurador.Text = leer["procurador"].ToString();
                cbx_razon.Text = leer["razon"].ToString();
                txt_costo.Text = leer["costo"].ToString();
                txt_abonos.Text = leer["abonos"].ToString();
                txt_impuesto.Text = leer["impuesto"].ToString();
                richTextBox1.Text = leer["notas"].ToString();

                con.Close();
            }
            else
            {
                MessageBox.Show("No esta Registrado, Puede Procesar el Divorcio");
                this.cbx_cliente.Select();
                this.cbx_cliente.Enabled = true;
                this.cbx_abogado.Enabled = true;
                this.cbx_juez.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_razon.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_impuesto.Enabled = true;
                this.richTextBox1.Enabled = true;

                con.Close();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
                       crud obcrud = new crud();

            if (txt_costo.Text == "")
            {
                MessageBox.Show("El Costo No Puede Ir en Blanco");
                txt_costo.Select();
                txt_costo.Focus();
            }
            else
            {
                
            if (txt_abonos.Text == "")
            {
                MessageBox.Show("Los Abonos No Puede Ir en Blanco");
                txt_abonos.Select();
                txt_abonos.Focus();
            }
            else
            {
                if (txt_impuesto.Text == "")
                {
                    MessageBox.Show("El impuesto No Puede Ir en Blanco");
                    txt_impuesto.Select();
                    txt_impuesto.Focus();
                }
                else
                {

                                    string sql = "insert  into pr_divorcios(cliente, abogado, juez, procurador, razon, costo, abonos, impuestos, notas, date) values ('" + this.cbx_cliente.Text + "','" + this.cbx_abogado.Text + "','" + this.cbx_juez.Text + "','" + this.cbx_procurador.Text+"','" + this.cbx_razon.Text + "','" + this.txt_costo.Text + "','" + this.txt_abonos.Text + "','" + this.txt_impuesto.Text + "','" + this.richTextBox1.Text + "','"+this.dtp_contrato.Text+"')";
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

        private void btn_modificar_Click(object sender, EventArgs e)
        {
             crud obcrud = new crud();

            if (txt_costo.Text == "")
            {
                MessageBox.Show("El Costo No Puede Ir en Blanco");
                txt_costo.Select();
                txt_costo.Focus();
            }
            else
            {
                
            if (txt_abonos.Text == "")
            {
                MessageBox.Show("Los Abonos No Puede Ir en Blanco");
                txt_abonos.Select();
                txt_abonos.Focus();
            }
            else
            {
                if (txt_impuesto.Text == "")
                {
                    MessageBox.Show("El impuesto No Puede Ir en Blanco");
                    txt_impuesto.Select();
                    txt_impuesto.Focus();
                }
                else
                {
                    string campos = "cliente ='" + this.cbx_cliente.Text + "',abogado ='" + this.cbx_abogado.Text + "',juez ='" + this.cbx_juez.Text + "',procurador ='" + this.cbx_procurador.Text + "',razon ='" + this.cbx_razon.Text + "',costo ='" + this.txt_costo.Text + "',impuesto ='" + this.txt_impuesto.Text + "',abonos ='" + this.txt_abonos.Text + "',notas ='" + this.richTextBox1.Text + "'";
                    if (obcrud.actualizar("pr_divorcios", campos, "cliente = '" + this.cbx_cliente.Text + "'"))
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
             object celda;
            crud obcrud = new crud();

            celda = dataGridView2.CurrentCell.Value;

            string condicion = "cliente='" + celda + "'";
            if (obcrud.actualizar("pr_divorcios", "hidden = 1", condicion))
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

        private void button3_Click(object sender, EventArgs e)
        {
            frm_clientes cl= new frm_clientes();
            cl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_abogados ab = new frm_abogados();
            ab.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_jueces cl = new frm_jueces();
            cl.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.cbx_cliente.Enabled = true;
                this.cbx_abogado.Enabled = true;
                this.cbx_juez.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_razon.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_impuesto.Enabled = true;
                this.richTextBox1.Enabled = true;


                string cadsql = "select * from pr_divorcios where cliente='" + maskedTextBox1.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_cliente.Text = leer["cliente"].ToString();
                    cbx_abogado.Text = leer["abogado"].ToString();
                    cbx_juez.Text = leer["juez"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_razon.Text = leer["razon"].ToString();
                    txt_costo.Text = leer["costo"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_impuesto.Text = leer["impuestos"].ToString();
                    richTextBox1.Text = leer["notas"].ToString();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado, Puede Procesar el Divorcio");
                    this.cbx_cliente.Select();
                    this.cbx_cliente.Enabled = true;
                    this.cbx_abogado.Enabled = true;
                    this.cbx_juez.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_razon.Enabled = true;
                    this.txt_costo.Enabled = true;
                    this.txt_abonos.Enabled = true;
                    this.txt_impuesto.Enabled = true;
                    this.richTextBox1.Enabled = true;

                    con.Close();
                }
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cliente, abogado, juez, procurador, razon, costo, abonos, impuestos, notas  FROM pr_divorcios where cliente like ('" + maskedTextBox1.Text + "%') and hidden =0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rango_divorcio divorcio = new rango_divorcio();
            divorcio.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            maskedTextBox1.Visible = true;
            mtb_pasaporte.Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            maskedTextBox1.Visible = false;
            mtb_pasaporte.Visible = true;
        }

        private void mtb_pasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.cbx_cliente.Enabled = true;
                this.cbx_abogado.Enabled = true;
                this.cbx_juez.Enabled = true;
                this.cbx_procurador.Enabled = true;
                this.cbx_razon.Enabled = true;
                this.txt_costo.Enabled = true;
                this.txt_abonos.Enabled = true;
                this.txt_impuesto.Enabled = true;
                this.richTextBox1.Enabled = true;


                string cadsql = "select * from pr_divorcios where cliente='" + mtb_pasaporte.Text + "'";
                MySqlCommand com = new MySqlCommand(cadsql, con);
                con.Open();
                MySqlDataReader leer = com.ExecuteReader();
                if (leer.Read() == true)
                {
                    cbx_cliente.Text = leer["cliente"].ToString();
                    cbx_abogado.Text = leer["abogado"].ToString();
                    cbx_juez.Text = leer["juez"].ToString();
                    cbx_procurador.Text = leer["procurador"].ToString();
                    cbx_razon.Text = leer["razon"].ToString();
                    txt_costo.Text = leer["costo"].ToString();
                    txt_abonos.Text = leer["abonos"].ToString();
                    txt_impuesto.Text = leer["impuestos"].ToString();
                    richTextBox1.Text = leer["notas"].ToString();

                    con.Close();
                }
                else
                {
                    MessageBox.Show("No esta Registrado, Puede Procesar el Divorcio");
                    this.cbx_cliente.Select();
                    this.cbx_cliente.Enabled = true;
                    this.cbx_abogado.Enabled = true;
                    this.cbx_juez.Enabled = true;
                    this.cbx_procurador.Enabled = true;
                    this.cbx_razon.Enabled = true;
                    this.txt_costo.Enabled = true;
                    this.txt_abonos.Enabled = true;
                    this.txt_impuesto.Enabled = true;
                    this.richTextBox1.Enabled = true;

                    con.Close();
                }
            }
        }

        private void mtb_pasaporte_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cliente, abogado, juez, procurador, razon, costo, abonos, impuestos, notas  FROM pr_divorcios where cliente like ('" + mtb_pasaporte.Text + "%') and hidden =0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dataGridView2.Visible = true;
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            con.Close();
        }   
    }
}
