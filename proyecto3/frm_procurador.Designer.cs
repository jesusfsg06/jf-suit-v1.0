namespace proyecto3
{
    partial class frm_procurador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_procurador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_genero = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelbuscar = new System.Windows.Forms.Panel();
            this.lbl_buscador = new System.Windows.Forms.Label();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_procu_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_procuraduria = new System.Windows.Forms.ComboBox();
            this.panelbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_genero
            // 
            this.cbx_genero.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_genero.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_genero.ForeColor = System.Drawing.Color.SlateGray;
            this.cbx_genero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbx_genero.Location = new System.Drawing.Point(381, 105);
            this.cbx_genero.Name = "cbx_genero";
            this.cbx_genero.Size = new System.Drawing.Size(150, 26);
            this.cbx_genero.Sorted = true;
            this.cbx_genero.TabIndex = 513;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(337, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 514;
            this.label11.Text = "Sexo";
            // 
            // panelbuscar
            // 
            this.panelbuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbuscar.Controls.Add(this.lbl_buscador);
            this.panelbuscar.Controls.Add(this.txt_buscador);
            this.panelbuscar.Controls.Add(this.btn_buscar);
            this.panelbuscar.Location = new System.Drawing.Point(304, 1);
            this.panelbuscar.Name = "panelbuscar";
            this.panelbuscar.Size = new System.Drawing.Size(362, 45);
            this.panelbuscar.TabIndex = 508;
            // 
            // lbl_buscador
            // 
            this.lbl_buscador.AutoSize = true;
            this.lbl_buscador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscador.ForeColor = System.Drawing.Color.White;
            this.lbl_buscador.Location = new System.Drawing.Point(8, 10);
            this.lbl_buscador.Name = "lbl_buscador";
            this.lbl_buscador.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_buscador.Size = new System.Drawing.Size(115, 25);
            this.lbl_buscador.TabIndex = 56;
            this.lbl_buscador.Text = "Cedula/Pasaporte";
            // 
            // txt_buscador
            // 
            this.txt_buscador.BackColor = System.Drawing.Color.White;
            this.txt_buscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscador.ForeColor = System.Drawing.Color.Red;
            this.txt_buscador.Location = new System.Drawing.Point(128, 10);
            this.txt_buscador.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_buscador.MinimumSize = new System.Drawing.Size(139, 27);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(139, 27);
            this.txt_buscador.TabIndex = 44;
            this.txt_buscador.TextChanged += new System.EventHandler(this.txt_buscador_TextChanged_1);
            this.txt_buscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscador_KeyPress_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(273, 9);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(72, 27);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.Text = "      Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(707, 441);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(108, 48);
            this.btn_salir.TabIndex = 507;
            this.btn_salir.Text = "        Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 194);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(690, 300);
            this.dataGridView2.TabIndex = 506;
            this.dataGridView2.Visible = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.White;
            this.txt_cedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cedula.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_cedula.Location = new System.Drawing.Point(83, 60);
            this.txt_cedula.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_cedula.MaxLength = 25;
            this.txt_cedula.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(150, 28);
            this.txt_cedula.TabIndex = 505;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 504;
            this.label4.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-1, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 493;
            this.label2.Text = "Procuraduria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(26, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 491;
            this.label8.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_nombre.Location = new System.Drawing.Point(83, 102);
            this.txt_nombre.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 28);
            this.txt_nombre.TabIndex = 490;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(82, 101);
            this.pictureBox10.MaximumSize = new System.Drawing.Size(110, 20);
            this.pictureBox10.MinimumSize = new System.Drawing.Size(152, 30);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(152, 30);
            this.pictureBox10.TabIndex = 492;
            this.pictureBox10.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(326, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 488;
            this.label3.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.White;
            this.txt_apellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apellido.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.ForeColor = System.Drawing.Color.SlateGray;
            this.txt_apellido.Location = new System.Drawing.Point(382, 64);
            this.txt_apellido.MaximumSize = new System.Drawing.Size(139, 27);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.MinimumSize = new System.Drawing.Size(150, 28);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 28);
            this.txt_apellido.TabIndex = 487;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(381, 63);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(110, 20);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(152, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 30);
            this.pictureBox4.TabIndex = 489;
            this.pictureBox4.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(707, 303);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(108, 48);
            this.btn_eliminar.TabIndex = 486;
            this.btn_eliminar.Text = "       Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_modificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_modificar.FlatAppearance.BorderSize = 0;
            this.btn_modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.Location = new System.Drawing.Point(707, 249);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(108, 48);
            this.btn_modificar.TabIndex = 485;
            this.btn_modificar.Text = "       Modificar";
            this.btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click_1);
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
            this.btn_nuevo.Location = new System.Drawing.Point(707, 195);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(108, 48);
            this.btn_nuevo.TabIndex = 484;
            this.btn_nuevo.Text = "       Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn6,
            this.Jurisdiccion});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(2, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 300);
            this.dataGridView1.TabIndex = 483;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Fizcalia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Juzgado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Jurisdiccion
            // 
            this.Jurisdiccion.HeaderText = "Jurisdiccion";
            this.Jurisdiccion.Name = "Jurisdiccion";
            this.Jurisdiccion.ReadOnly = true;
            // 
            // cbx_procu_type
            // 
            this.cbx_procu_type.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_procu_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_procu_type.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_procu_type.ForeColor = System.Drawing.Color.SlateGray;
            this.cbx_procu_type.Items.AddRange(new object[] {
            "Asistente del Procurador",
            "Procudor Adjunto",
            "Procurador General"});
            this.cbx_procu_type.Location = new System.Drawing.Point(382, 147);
            this.cbx_procu_type.Name = "cbx_procu_type";
            this.cbx_procu_type.Size = new System.Drawing.Size(150, 26);
            this.cbx_procu_type.Sorted = true;
            this.cbx_procu_type.TabIndex = 515;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(259, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 516;
            this.label1.Text = "Tipo de Procurador";
            // 
            // cbx_procuraduria
            // 
            this.cbx_procuraduria.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_procuraduria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_procuraduria.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_procuraduria.ForeColor = System.Drawing.Color.SlateGray;
            this.cbx_procuraduria.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbx_procuraduria.Location = new System.Drawing.Point(82, 147);
            this.cbx_procuraduria.Name = "cbx_procuraduria";
            this.cbx_procuraduria.Size = new System.Drawing.Size(150, 26);
            this.cbx_procuraduria.Sorted = true;
            this.cbx_procuraduria.TabIndex = 517;
            // 
            // frm_procurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 500);
            this.Controls.Add(this.cbx_procuraduria);
            this.Controls.Add(this.cbx_procu_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_genero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelbuscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_procurador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procuradores";
            this.Load += new System.EventHandler(this.frm_procurador_Load);
            this.panelbuscar.ResumeLayout(false);
            this.panelbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_genero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelbuscar;
        private System.Windows.Forms.Label lbl_buscador;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jurisdiccion;
        private System.Windows.Forms.ComboBox cbx_procu_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_procuraduria;
    }
}