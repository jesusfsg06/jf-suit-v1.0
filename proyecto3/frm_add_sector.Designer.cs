namespace proyecto3
{
    partial class frm_add_sector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_sector));
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.cbx_provincias = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(378, 107);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(108, 48);
            this.btn_nuevo.TabIndex = 522;
            this.btn_nuevo.Text = "       Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // cbx_provincias
            // 
            this.cbx_provincias.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_provincias.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_provincias.ForeColor = System.Drawing.Color.SlateGray;
            this.cbx_provincias.ItemHeight = 18;
            this.cbx_provincias.Location = new System.Drawing.Point(336, 32);
            this.cbx_provincias.Name = "cbx_provincias";
            this.cbx_provincias.Size = new System.Drawing.Size(150, 26);
            this.cbx_provincias.Sorted = true;
            this.cbx_provincias.TabIndex = 520;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(271, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 15);
            this.label24.TabIndex = 521;
            this.label24.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 518;
            this.label3.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_nombre.Location = new System.Drawing.Point(72, 29);
            this.txt_nombre.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 28);
            this.txt_nombre.TabIndex = 517;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(71, 28);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(110, 20);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(152, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 30);
            this.pictureBox4.TabIndex = 519;
            this.pictureBox4.TabStop = false;
            // 
            // frm_add_sector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 167);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.cbx_provincias);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_add_sector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Sector";
            this.Load += new System.EventHandler(this.frm_add_sector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.ComboBox cbx_provincias;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}