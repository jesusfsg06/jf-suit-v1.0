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
    public partial class frm_login : Form
    {
        int a = 0;

        public frm_login()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("user.png");
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            txt_user.Select();
            txt_user.Focus();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {

            if (a == 2)
            {
                MessageBox.Show("A Excedido el Numero de Intentos", "Alerta");

                this.Close();
            }
            else
            {
                if (txt_user.Text == "")
                {
                    a = a + 1;
                    errorProvider1.SetError(txt_user, "Campo Usuario Vacio, Intento #'" + a + "', Al tercer intento se cerrara el Sistema");

                    txt_user.Focus();
                }
                else
                {
                    if (txt_password.Text == "")
                    {
                        a = a + 1;
                        errorProvider1.SetError(txt_password, "Campo Contrasena Vacio, Intento #'" + a + "', Al tercer intento se cerrara el Sistema");
                        txt_password.Focus();
                    }
                    else
                    {
                        MySqlConnection con = new MySqlConnection();
                        string cadena;
                        cadena = "server=localhost;user id=root; database=proyecto3; password=";
                        con.ConnectionString = cadena;
                        con.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter("Select count(*) from pr_users where username='" + txt_user.Text + "' and password='" + txt_password.Text + "'", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            this.Hide();
                            menu ss = new menu();
                            ss.Show();
                        }
                        else
                        {
                            a = a + 1;
                            MessageBox.Show("Datos Incorrectos, Intento #'" + a + "', Al tercer intento se cerrara el Sistema", "Alerta");
                            txt_user.Clear();
                            txt_password.Clear();
                            txt_user.Focus();
                        }
                    }
                }
            }
        }

        private void frm_login_Load_1(object sender, EventArgs e)
        {
            txt_user.Select();
            txt_user.Focus();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_aceptar.Focus();
                btn_aceptar.Select();
            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_aceptar.Focus();
                btn_aceptar.Select();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
   }
}

