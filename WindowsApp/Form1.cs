using LibreríaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto uno = new Producto("Auto", "Auto azul usado", 80000, 0.8, 0.21, "Automotores Fiat", "Vehículos", "Autos");

            MessageBox.Show("Producto:" + " " + uno.Nombre + ", " + uno.Descripcion + ", " + "el precio costo es " + uno.PrecioCosto + ", " +
                "el margen es " + uno.Margen + ", " + "el IVA es " + uno.IVA + ", " + uno.Proveedor + ", " + "categoría: " + uno.Categoria + ", " + uno.SubCategoria + ". " +
                "El PRECIO BRUTO es " + uno.PrecioBruto + ", " + "y el precio de VENTA es " + uno.PrecioVenta);

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            ClienteIndividuo newClient = new ClienteIndividuo("Martina", "Ceschan", "27-41185856-7", "martinaceschan@gmail.com", "2953410529", "Bahía Blanca, Buenos Aires");

            MessageBox.Show("Cliente:" + " " + newClient.Nombre + " " + newClient.Apellido + ", " + "CUIT: " + newClient.CUIT + ", " + "EMAIL: " +
                newClient.Email + ", " + "TELEFONO: " + newClient.Telefono + ", " + "DIRECCIÓN: " + newClient.Direccion);

        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            Vendedor newVendedor = new Vendedor("Laura", "López", "40256897", "laura@gmail.com", "2953568911", "Córdoba");

            MessageBox.Show("Vendedor: " + newVendedor.Nombre + " " + newVendedor.Apellido + ", DNI: " + newVendedor.DNI + ", EMAIL: " + newVendedor.Email + ", TELEFONO: " + newVendedor.Telefono + ", DIRECCION: " + newVendedor.Direccion);
        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            Empresa newEmpresa = new Empresa("Automotores Fiat", "21-25698-7", "Alberto Gómez", "alberto@gmail.com", "295342568", "Córdoba");
            MessageBox.Show("Empresa: " + newEmpresa.Nombre + ", CUIT: " + newEmpresa.CUIT + ", CONTACTO: " + newEmpresa.Contacto + ", EMAIL: " + newEmpresa.Email + ", TELEFONO: " + newEmpresa.Telefono + ", DIRECCION: " + newEmpresa.Direccion);

        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            Factura newFactura = new Factura("A", "589647-12", DateTime.Now, "Carlos", "Corrientes", "Consumidor final", "AA", "Venta automovil usado azul", 800000);

            MessageBox.Show("Factura tipo: " + newFactura.Tipo + ", Numero: " + newFactura.Numero + ", FECHA: " + newFactura.Fecha.ToString() + ", CLIENTE: " + newFactura.Cliente + ", DIRECCIÓN: " + newFactura.Direccion + ", CondicionIVA: " + newFactura.CondicionIVA + ", Condicion Venta: " + newFactura.CondicionVenta + ", DETALLE: " + newFactura.Detalle + ", TOTAL: " + newFactura.Total);
        }

        private void btnCrearRemito_Click(object sender, EventArgs e)
        {
            Remito newRemito = new Remito("566625-7", DateTime.Now, "Carlos", "Corrientes", "Consumidor final", "AA", "Venta automovil usado azul", DateTime.Now, 800000);

            MessageBox.Show("Remito Numero: " + newRemito.Numero + ", FECHA: " + newRemito.Fecha.ToString() + ", CLIENTE: " + newRemito.Cliente + ", DIRECCIÓN: " + newRemito.Direccion + ", CondicionIVA: " + newRemito.CondicionIVA + ", Condicion Venta: " + newRemito.CondicionVenta + ", DETALLE: " + newRemito.Detalle + ", FECHA DE ENTREGA: " + newRemito.FechaEntrega.ToString() + ", TOTAL: " + newRemito.Total);
        }
    }
}
