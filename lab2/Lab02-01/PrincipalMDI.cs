using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            ManUsuario frm = new ManUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            ManProductos frm = new ManProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            ManCategorias frm = new ManCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManPreveedores_Click(object sender, EventArgs e)
        {
            ManProveedores frm = new ManProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            ManClientes frm = new ManClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuProcesoVenta_Click(object sender, EventArgs e)
        {
            ProcesoVentas frm = new ProcesoVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReporteVentas_Click(object sender, EventArgs e)
        {
            ProcesoCompras frm = new ProcesoCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteCompras frm = new ReporteCompras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReporteInventario_Click(object sender, EventArgs e)
        {
            ReporteInventario frm = new ReporteInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReporteProveedores_Click(object sender, EventArgs e)
        {
            ReporteProveedores frm = new ReporteProveedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReporteUsuarios_Click(object sender, EventArgs e)
        {
            ReporteUsuarios frm = new ReporteUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuReporteClientes_Click(object sender, EventArgs e)
        {
            ReporteClientes frm = new ReporteClientes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
