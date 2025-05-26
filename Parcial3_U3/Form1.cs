using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3_U3
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            StreamWriter archivo = null;
            validaciones val = new validaciones();
            //MessageBox.Show("Hola");
            string nombre = Nametxt.Text;
            string edad = Agetxt.Text;
            if (val.validarlet(nombre)){
                if (val.validarnum(edad))
                {
                    archivo = File.AppendText("datos.csv");
                    string cadena = nombre + "," + edad;
                    archivo.WriteLine(cadena);
                    archivo.Close();
                    Nametxt.Text = "";
                    Agetxt.Text = "";
                }
                else
                {
                    MessageBox.Show("La edad ingresada no consiste de unicamente numeros");
                    Agetxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El nombre ingresado no son puras letras");
                Nametxt.Text = "";
            }

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muestre mostrar= new muestre();
            mostrar.ShowDialog();
        }

        private void Nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>=48 && e.KeyChar <= 57) || e.KeyChar >= 97  && e.KeyChar <= 122 || (e.KeyChar==32)||(e.KeyChar==08))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void Agetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=48 && e.KeyChar <= 57) || (e.KeyChar >= 08))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
