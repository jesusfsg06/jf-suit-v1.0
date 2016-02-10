using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class frm_add_provincia : Form
    {
        public frm_add_provincia()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("El Nombre No Puede Ir en Blanco");
                txt_nombre.Select();
                txt_nombre.Focus();
            }
            else
            {

                if (cbx_pais.Text == "")
                {
                    MessageBox.Show("El pais No Puede Ir en Blanco");
                    cbx_pais.Select();
                    cbx_pais.Focus();
                }
                else
                {
                    string sql = "insert  into pr_provincias (nombre, pais) values ('" + this.txt_nombre.Text + "','" + this.cbx_pais.Text + "')";
                    if (obcrud.insertar(sql))
                    {
                        MessageBox.Show("Se ha agregado Correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Se ha Podido insertar");
                    }
                }
            }
        }

        private void frm_add_provincia_Load(object sender, EventArgs e)
        {

        }

        private void cbx_pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
