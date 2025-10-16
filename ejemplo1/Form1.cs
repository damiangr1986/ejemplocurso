using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwelementos.Items.Add(elem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbocolorfavorito.Items.Add("Rojo");
            cbocolorfavorito.Items.Add("Verde");
            cbocolorfavorito.Items.Add("Negro");
        }

        private void lblverperfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechadenacimiento.Value;
            //operador ternario
            string chocolate = chbchocolate.Checked == true ? "le gusta el choco" : "odia el choco";

            string tipo;
            if (rbwizard.Checked)
                tipo = "Wizzard";
            else if (rbtCarry.Checked)
                tipo = "Carry";
            else 
                tipo = "Tank";

            string colorFavorito = cbocolorfavorito.SelectedItem.ToString();
            string numeroFavorito = nudnumerofavorito.Value.ToString();
            string mensaje = chocolate + ", " + " es " + tipo + ", su color es " + colorFavorito + ", su numero favorito es " + numeroFavorito;
            MessageBox.Show("Nombre " + nombre + " Fecha: " + fecha + "," + mensaje);



             
        }
    }
}
