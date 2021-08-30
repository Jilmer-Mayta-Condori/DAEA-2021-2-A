
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManPreveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesoVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesoCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.mnuReporteCompra,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManPreveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcesoVenta,
            this.mnuProcesoCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuReporteCompra
            // 
            this.mnuReporteCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReporteVentas,
            this.reporteCompraToolStripMenuItem,
            this.mnuReporteInventario,
            this.mnuReporteProveedores,
            this.mnuReporteUsuarios,
            this.mnuReporteClientes});
            this.mnuReporteCompra.Name = "mnuReporteCompra";
            this.mnuReporteCompra.Size = new System.Drawing.Size(82, 26);
            this.mnuReporteCompra.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManPreveedores
            // 
            this.mnuManPreveedores.Name = "mnuManPreveedores";
            this.mnuManPreveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManPreveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuProcesoVenta
            // 
            this.mnuProcesoVenta.Name = "mnuProcesoVenta";
            this.mnuProcesoVenta.Size = new System.Drawing.Size(224, 26);
            this.mnuProcesoVenta.Text = "Registrar Venta";
            // 
            // mnuProcesoCompra
            // 
            this.mnuProcesoCompra.Name = "mnuProcesoCompra";
            this.mnuProcesoCompra.Size = new System.Drawing.Size(224, 26);
            this.mnuProcesoCompra.Text = "Registrar Compra";
            this.mnuProcesoCompra.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // mnuReporteVentas
            // 
            this.mnuReporteVentas.Name = "mnuReporteVentas";
            this.mnuReporteVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuReporteVentas.Text = "Reporte Venta";
            // 
            // reporteCompraToolStripMenuItem
            // 
            this.reporteCompraToolStripMenuItem.Name = "reporteCompraToolStripMenuItem";
            this.reporteCompraToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.reporteCompraToolStripMenuItem.Text = "Reporte Compra";
            // 
            // mnuReporteInventario
            // 
            this.mnuReporteInventario.Name = "mnuReporteInventario";
            this.mnuReporteInventario.Size = new System.Drawing.Size(252, 26);
            this.mnuReporteInventario.Text = "Inventario de Productos";
            // 
            // mnuReporteProveedores
            // 
            this.mnuReporteProveedores.Name = "mnuReporteProveedores";
            this.mnuReporteProveedores.Size = new System.Drawing.Size(252, 26);
            this.mnuReporteProveedores.Text = "Reporte de Proveedores";
            // 
            // mnuReporteUsuarios
            // 
            this.mnuReporteUsuarios.Name = "mnuReporteUsuarios";
            this.mnuReporteUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnuReporteUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuReporteClientes
            // 
            this.mnuReporteClientes.Name = "mnuReporteClientes";
            this.mnuReporteClientes.Size = new System.Drawing.Size(252, 26);
            this.mnuReporteClientes.Text = "Reporte de clientes";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSalir.Text = "Salir del Sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManPreveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesoVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesoCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteCompra;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem reporteCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteInventario;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}