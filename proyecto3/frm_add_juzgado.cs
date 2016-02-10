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
    public partial class frm_add_juzgado : Form
    {
        public frm_add_juzgado()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            crud obcrud = new crud();

            if (txt_circuns.Text == "")
            {
                MessageBox.Show("El Nombre No Puede Ir en Blanco");
                txt_circuns.Select();
                txt_circuns.Focus();
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
                    if (txt_abogado.Text == "")
                    {
                        MessageBox.Show("El Fiscal No Puede Ir en Blanco");
                        txt_abogado.Select();
                        txt_abogado.Focus();
                    }
                    else
                    {
                            string sql = "insert  into pr_juzgado_paz(circunscripcion, direccion, pais, juez) values ('" + this.txt_circuns.Text + "','" + this.txt_direccion.Text + "','" + this.cbx_pais.Text + "','" + this.txt_abogado.Text + "')";
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
        }
    }
}
