using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

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
            Producto p = new Producto();

            p.Nombre = "Replica Copa del Mundo";
            p.Descricion = "Replica a escala de la copa del mundo";
            p.PrecioCosto = 100;
            p.IVA = 0.21;
            p.Margen = 0.15;
            p.Proveedor = "Panini";
            p.Categoria = "Decoracion";
            p.SubCategoria = "Trofeos";


            MessageBox.Show($"PRODUCTO: \nNombre: {p.Nombre} \nDescripcion: {p.Descricion} \nPrecio de costo: ${p.PrecioCosto}" +
                $"\nIVA: {p.IVA} \nMargen: {p.Margen} \nProveedor: {p.Proveedor} \nCategoria: {p.Categoria} \nSubcategoria: {p.SubCategoria}" +
                $"\nPrecio Bruto: ${p.PrecioBruto} \nPrecio de Venta: ${p.PrecioVenta}"
            );
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            ClienteIndividuo c = new ClienteIndividuo();

            c.Nombre = "Pedro";
            c.Apellido = "Silva";
            c.CUIT = "30284055155";
            c.Email = "pedrosilva@gmail.com";
            c.Telefono = "3415689654";
            c.Direccion = "Pellegrini 1215";

            MessageBox.Show($"CLIENTE INDIVIDUAL: \nNombre: {c.Nombre} \nApellido: {c.Apellido} \nCUIT: {c.CUIT}" +
                $"\nEmail: {c.Email} \nTelefono: {c.Telefono} \nDireccion: {c.Direccion}");

        }
    }
}
