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
    public partial class PrincipalMDI1 : Form
    {
        public PrincipalMDI1()
        {
            InitializeComponent();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            MantenimientoUsuario mantenimiento = new MantenimientoUsuario();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProductos productos = new manProductos();
            productos.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategorias categorias = new manCategorias();
            categorias.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedores proveedores = new manProveedores();
            proveedores.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes clientes = new manClientes();
            clientes.Show();
            this.Hide();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regVentas ventas = new regVentas();
            ventas.Show();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regCompras compras = new regCompras();
            compras.Show();
            this.Hide();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repVentas ventas = new repVentas();
            ventas.Show();
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regCompras compras = new regCompras();
            compras.Show();
        }

        private void inventarioDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repInventario inventario = new repInventario();
            inventario.Show();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repProveedores proveedores = new repProveedores();
            proveedores.Show();
            this.Hide();
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repUsuarios usuarios = new repUsuarios();
            usuarios.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repClientes clientes = new repClientes();
            clientes.Show();
        }
    }
}
