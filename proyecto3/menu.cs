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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.Show();
        }

        private void agregarAbogadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_abogados abogados = new frm_abogados();
            abogados.Show();
        }

        private void agregarTercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_terceros terceros = new frm_terceros();
            terceros.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void divorciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_divorcio divorcio = new frm_divorcio();
            divorcio.Show();
        }

        private void procuradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_procurador procurador = new frm_procurador();
            procurador.Show();
        }

        private void juecesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_jueces jueces = new frm_jueces();
            jueces.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes clientes = new frm_clientes();
            clientes.Show();
        }

        private void abogadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_abogados abogados = new frm_abogados();
            abogados.Show();
        }

        private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_terceros terceros = new frm_terceros();
            terceros.Show();
        }

        private void contratoVentaDeInmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venta venta = new frm_venta();
            venta.Show();
        }

        private void contratoDeAlquilerDeInmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_alquiler alquiler = new frm_alquiler();
            alquiler.Show();
        }

        private void contratoCompraInmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_compra compra = new frm_compra();
            compra.Show();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cotizacion cot = new frm_cotizacion();
            cot.Show();
        }

        private void gastosPorExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_gastos_expedientes gastos = new frm_gastos_expedientes();
            gastos.Show();
        }

        private void abonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_abonos ab = new frm_abonos();
            ab.Show();
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_recibo rec = new frm_recibo();
            rec.Show();
        }
    }
}
