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
    public partial class frm_add_jurisdiccion : Form
    {
        public frm_add_jurisdiccion()
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

                if (txt_direccion.Text == "")
                {
                    MessageBox.Show("La Direccion No Puede Ir en Blanco");
                    txt_direccion.Select();
                    txt_direccion.Focus();
                }
                else
                {
                    if (cbx_pais.Text == "")
                    {
                        MessageBox.Show("El Fiscal No Puede Ir en Blanco");
                        cbx_pais.Select();
                        cbx_pais.Focus();
                    }
                    else
                    {
                        string sql = "insert  into pr_jurisdiccion (nombre, direccion, pais) values ('" + this.txt_nombre.Text + "','" + this.txt_direccion.Text + "','" + this.cbx_pais.Text + "')";
                            if (obcrud.insertar(sql))
                            {
                                MessageBox.Show("Se ha agregado Correctamente");
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
