namespace proyecto3
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAbogadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTercerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procuradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juzgadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurisdiccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizcaliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abogadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tercerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divorciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoVentaDeInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoCompraInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gastosPorExpedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClientesToolStripMenuItem,
            this.agregarAbogadosToolStripMenuItem,
            this.agregarTercerosToolStripMenuItem,
            this.juecesToolStripMenuItem,
            this.procuradorToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.archivoToolStripMenuItem.Text = "Consultas";
            // 
            // agregarClientesToolStripMenuItem
            // 
            this.agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            this.agregarClientesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.agregarClientesToolStripMenuItem.Text = "Clientes";
            this.agregarClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarClientesToolStripMenuItem_Click);
            // 
            // agregarAbogadosToolStripMenuItem
            // 
            this.agregarAbogadosToolStripMenuItem.Name = "agregarAbogadosToolStripMenuItem";
            this.agregarAbogadosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.agregarAbogadosToolStripMenuItem.Text = "Abogados";
            this.agregarAbogadosToolStripMenuItem.Click += new System.EventHandler(this.agregarAbogadosToolStripMenuItem_Click);
            // 
            // agregarTercerosToolStripMenuItem
            // 
            this.agregarTercerosToolStripMenuItem.Name = "agregarTercerosToolStripMenuItem";
            this.agregarTercerosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.agregarTercerosToolStripMenuItem.Text = "Terceros";
            this.agregarTercerosToolStripMenuItem.Click += new System.EventHandler(this.agregarTercerosToolStripMenuItem_Click);
            // 
            // juecesToolStripMenuItem
            // 
            this.juecesToolStripMenuItem.Name = "juecesToolStripMenuItem";
            this.juecesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.juecesToolStripMenuItem.Text = "Jueces";
            this.juecesToolStripMenuItem.Click += new System.EventHandler(this.juecesToolStripMenuItem_Click);
            // 
            // procuradorToolStripMenuItem
            // 
            this.procuradorToolStripMenuItem.Name = "procuradorToolStripMenuItem";
            this.procuradorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.procuradorToolStripMenuItem.Text = "Procurador";
            this.procuradorToolStripMenuItem.Click += new System.EventHandler(this.procuradorToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juzgadoToolStripMenuItem,
            this.jurisdiccionToolStripMenuItem,
            this.fizcaliaToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.abogadoToolStripMenuItem,
            this.tercerosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // juzgadoToolStripMenuItem
            // 
            this.juzgadoToolStripMenuItem.Name = "juzgadoToolStripMenuItem";
            this.juzgadoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.juzgadoToolStripMenuItem.Text = "Juzgado";
            // 
            // jurisdiccionToolStripMenuItem
            // 
            this.jurisdiccionToolStripMenuItem.Name = "jurisdiccionToolStripMenuItem";
            this.jurisdiccionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.jurisdiccionToolStripMenuItem.Text = "Jurisdiccion";
            // 
            // fizcaliaToolStripMenuItem
            // 
            this.fizcaliaToolStripMenuItem.Name = "fizcaliaToolStripMenuItem";
            this.fizcaliaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fizcaliaToolStripMenuItem.Text = "Fizcalia";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // abogadoToolStripMenuItem
            // 
            this.abogadoToolStripMenuItem.Name = "abogadoToolStripMenuItem";
            this.abogadoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.abogadoToolStripMenuItem.Text = "Abogado";
            this.abogadoToolStripMenuItem.Click += new System.EventHandler(this.abogadoToolStripMenuItem_Click);
            // 
            // tercerosToolStripMenuItem
            // 
            this.tercerosToolStripMenuItem.Name = "tercerosToolStripMenuItem";
            this.tercerosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.tercerosToolStripMenuItem.Text = "Terceros";
            this.tercerosToolStripMenuItem.Click += new System.EventHandler(this.tercerosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.divorciosToolStripMenuItem,
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem,
            this.contratoVentaDeInmuebleToolStripMenuItem,
            this.contratoCompraInmuebleToolStripMenuItem,
            this.gastosPorExpedientesToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // divorciosToolStripMenuItem
            // 
            this.divorciosToolStripMenuItem.Name = "divorciosToolStripMenuItem";
            this.divorciosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.divorciosToolStripMenuItem.Text = "Divorcios";
            this.divorciosToolStripMenuItem.Click += new System.EventHandler(this.divorciosToolStripMenuItem_Click);
            // 
            // contratoDeAlquilerDeInmuebleToolStripMenuItem
            // 
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem.Name = "contratoDeAlquilerDeInmuebleToolStripMenuItem";
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem.Text = "Contrato de Alquiler de inmueble";
            this.contratoDeAlquilerDeInmuebleToolStripMenuItem.Click += new System.EventHandler(this.contratoDeAlquilerDeInmuebleToolStripMenuItem_Click);
            // 
            // contratoVentaDeInmuebleToolStripMenuItem
            // 
            this.contratoVentaDeInmuebleToolStripMenuItem.Name = "contratoVentaDeInmuebleToolStripMenuItem";
            this.contratoVentaDeInmuebleToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.contratoVentaDeInmuebleToolStripMenuItem.Text = "Contrato Venta de inmueble";
            this.contratoVentaDeInmuebleToolStripMenuItem.Click += new System.EventHandler(this.contratoVentaDeInmuebleToolStripMenuItem_Click);
            // 
            // contratoCompraInmuebleToolStripMenuItem
            // 
            this.contratoCompraInmuebleToolStripMenuItem.Name = "contratoCompraInmuebleToolStripMenuItem";
            this.contratoCompraInmuebleToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.contratoCompraInmuebleToolStripMenuItem.Text = "Contrato Compra Inmueble";
            this.contratoCompraInmuebleToolStripMenuItem.Click += new System.EventHandler(this.contratoCompraInmuebleToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionToolStripMenuItem,
            this.abonosToolStripMenuItem,
            this.reciboToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            this.cotizacionToolStripMenuItem.Click += new System.EventHandler(this.cotizacionToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // gastosPorExpedientesToolStripMenuItem
            // 
            this.gastosPorExpedientesToolStripMenuItem.Name = "gastosPorExpedientesToolStripMenuItem";
            this.gastosPorExpedientesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.gastosPorExpedientesToolStripMenuItem.Text = "Gastos Por Expedientes";
            this.gastosPorExpedientesToolStripMenuItem.Click += new System.EventHandler(this.gastosPorExpedientesToolStripMenuItem_Click);
            // 
            // abonosToolStripMenuItem
            // 
            this.abonosToolStripMenuItem.Name = "abonosToolStripMenuItem";
            this.abonosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abonosToolStripMenuItem.Text = "Abonos";
            this.abonosToolStripMenuItem.Click += new System.EventHandler(this.abonosToolStripMenuItem_Click);
            // 
            // reciboToolStripMenuItem
            // 
            this.reciboToolStripMenuItem.Name = "reciboToolStripMenuItem";
            this.reciboToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reciboToolStripMenuItem.Text = "Recibo";
            this.reciboToolStripMenuItem.Click += new System.EventHandler(this.reciboToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu (JF-SUIT)";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAbogadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTercerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem juecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procuradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divorciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juzgadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurisdiccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizcaliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abogadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoDeAlquilerDeInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoVentaDeInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoCompraInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosPorExpedientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboToolStripMenuItem;
    }
}