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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
               
                    frm_login entrada = new frm_login();
                    entrada.Show();
                    this.Hide();
                }

            }
        }
    }

