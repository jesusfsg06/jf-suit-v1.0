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
    public partial class frm_add_sector : Form
    {
        public frm_add_sector()
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
                if (cbx_provincias.Text == "")
                {
                    MessageBox.Show("El Fiscal No Puede Ir en Blanco");
                    cbx_provincias.Select();
                    cbx_provincias.Focus();
                }
                else
                {
                    string sql = "insert  into pr_sectores (nombre, provincia) values ('" + this.txt_nombre.Text + "','" + this.cbx_provincias.Text + "')";
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

        private void frm_add_sector_Load(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            this.cbx_provincias.DataSource = obcrud.consultar3("pr_provincias", "hidden= 0");
            this.cbx_provincias.DisplayMember = "nombre";
            this.cbx_provincias.ValueMember = "nombre";
            this.cbx_provincias.Refresh();

        }
    }
}
   
