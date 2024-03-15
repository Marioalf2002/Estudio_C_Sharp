using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CRUD_h1
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();
        int pos = -1;
        public Form1()
        {
            InitializeComponent();
            leerAP();
            leerLP();
        }
        private void lvwDatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pos = e.ItemIndex;
            if (e.IsSelected)
            {
                txtCodigo.Text = productos[pos].codigo;
                txtNombre.Text = productos[pos].nombre;
                txtCantidad.Text = productos[pos].cantidad;
                txtPrecio.Text = productos[pos].precio;
            }
        }
        public void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            pos = -1;
        }
        public void leerAP()
        {
            StreamReader srCodigo = new StreamReader("D:\\almacenamiento\\codigo.txt");
            StreamReader srNombre = new StreamReader("D:\\almacenamiento\\nombre.txt");
            StreamReader srCantidad = new StreamReader("D:\\almacenamiento\\cantidad.txt");
            StreamReader srPrecio = new StreamReader("D:\\almacenamiento\\precio.txt");

            string lCodigo = srCodigo.ReadLine();
            string lNombre = srNombre.ReadLine();
            string lCantidad = srCantidad.ReadLine();
            string lPrecio = srPrecio.ReadLine();

            while (lCodigo != null)
            {
                productos.Add(new Producto(lCodigo, lNombre, lCantidad, lPrecio));

                lCodigo = srCodigo.ReadLine();
                lNombre = srNombre.ReadLine();
                lCantidad = srCantidad.ReadLine();
                lPrecio = srPrecio.ReadLine();
            }

            srCodigo.Close();
            srNombre.Close();
            srCantidad.Close();
            srPrecio.Close();
        }
        public void CrearAP()
        {
            string codigo = "", nombre = "", cantidad = "", precio = "";
            foreach(Producto p in productos)
            {
                codigo = codigo + p.codigo + "\n";
                nombre = nombre + p.nombre + "\n";
                cantidad = cantidad + p.cantidad + "\n";
                precio = precio + p.precio + "\n";

                escribir("D:\\almacenamiento\\codigo.txt", codigo);
                escribir("D:\\almacenamiento\\nombre.txt", nombre);
                escribir("D:\\almacenamiento\\cantidad.txt", cantidad);
                escribir("D:\\almacenamiento\\precio.txt", precio);
            }
               
        }
        public void escribir(string _dir, string _dato)
        {
            StreamWriter sw = new StreamWriter(_dir);
            sw.Write(_dato);
            sw.Close();
        }
        public void leerLP()
        {
            lvwDatos.Items.Clear();

            foreach (Producto p in productos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.codigo.ToString();
                item.SubItems.Add(p.nombre);
                item.SubItems.Add(p.cantidad);
                item.SubItems.Add(p.precio.ToString());

                lvwDatos.Items.Add(item);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("¡Debes diligenciar todos los campos!");
            }
            else
            {
                productos.Add(new Producto(txtCodigo.Text, txtNombre.Text, txtCantidad.Text, txtPrecio.Text));
                CrearAP();
                limpiar();
                MessageBox.Show("¡Datos ingresados con exito!");
                leerLP();
            }
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
           
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(pos >= 0)
            {
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
                {
                    pos = -1;
                    limpiar();
                    MessageBox.Show("¡Debes diligenciar todos los campos!");
                }
                else
                {
                    productos[pos].codigo = txtCodigo.Text;
                    productos[pos].nombre = txtNombre.Text;
                    productos[pos].cantidad = txtCantidad.Text;
                    productos[pos].precio = txtPrecio.Text;
                    limpiar();
                    MessageBox.Show("¡Datos actualizados con exito!");
                }
            }
            else
            {
                MessageBox.Show("¡Debes seleccionar un item!");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pos >= 0)
            {
                productos.RemoveAt(pos);
                limpiar();
                MessageBox.Show("¡Datos eliminados con exito!");
            }
            else
            {
                MessageBox.Show("¡Debes seleccionar un item!");
            }
        }
    }
}
