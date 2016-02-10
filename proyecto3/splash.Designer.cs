namespace proyecto3
{
    partial class splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbl_copyr = new System.Windows.Forms.Label();
            this.lbl_esperar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(13, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 106);
            this.panel1.TabIndex = 14;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltitulo.Location = new System.Drawing.Point(183, 54);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(176, 31);
            this.lbltitulo.TabIndex = 11;
            this.lbltitulo.Text = "JF-Suit V1.0";
            // 
            // lbl_copyr
            // 
            this.lbl_copyr.AutoSize = true;
            this.lbl_copyr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_copyr.Font = new System.Drawing.Font("Arial", 6.5F);
            this.lbl_copyr.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_copyr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_copyr.Location = new System.Drawing.Point(275, 202);
            this.lbl_copyr.Name = "lbl_copyr";
            this.lbl_copyr.Size = new System.Drawing.Size(206, 24);
            this.lbl_copyr.TabIndex = 12;
            this.lbl_copyr.Text = "Programa Creado por Jesus Francisco Severino\r\n\r\n";
            // 
            // lbl_esperar
            // 
            this.lbl_esperar.AutoSize = true;
            this.lbl_esperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.lbl_esperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_esperar.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_esperar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_esperar.Location = new System.Drawing.Point(6, 125);
            this.lbl_esperar.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbl_esperar.MinimumSize = new System.Drawing.Size(480, 45);
            this.lbl_esperar.Name = "lbl_esperar";
            this.lbl_esperar.Size = new System.Drawing.Size(480, 45);
            this.lbl_esperar.TabIndex = 13;
            this.lbl_esperar.Text = "CARGANDO FUNCIONES";
            this.lbl_esperar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 164);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(471, 29);
            this.progressBar1.TabIndex = 10;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sub.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_sub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_sub.Location = new System.Drawing.Point(126, 31);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(194, 16);
            this.lbl_sub.TabIndex = 15;
            this.lbl_sub.Text = "SISTEMA PARA  ABOGADOS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 228);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lbl_copyr);
            this.Controls.Add(this.lbl_esperar);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbl_copyr;
        private System.Windows.Forms.Label lbl_esperar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Timer timer1;
    }
}