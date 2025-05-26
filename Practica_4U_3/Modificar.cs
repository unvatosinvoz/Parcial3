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

namespace Practica_4U_3
{
    public partial class Modificar : Form
    {
        public Modificar(string c, string n,string p,string i)
        {
            InitializeComponent();
            lblCod.Text = c;
            textBox1.Text = n;
            textBox2.Text = p;
            Image.FromFile(i);
        }
        private void eliminarDelArchivo(string i,string n,string p)
        {
            StreamReader archivo = File.OpenText("productos.csv");
            string renglon = "";
            StreamWriter aux = null;
            int c = 0;
            do
            {
                try
                {
                    renglon = archivo.ReadLine();
                    if (renglon != null)
                    {
                        String[] partes = renglon.Split(',');
                        //if (!partes[0].Equals(codigoArchivo))
                        //{
                        //aux = File.AppendText("remplazo.csv");
                        //string cadena = i + "," + n + "," + p + "," + partes[3];
                        //aux.WriteLine(cadena);
                        //aux.Close();
                        //}
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error" + e.Message);
                }
            } while (renglon != null);
            archivo.Close();
            File.Delete("productos.csv");
            if (File.Exists("remplazo.csv"))
            {
                File.Move("remplazo.csv", "productos.csv");
                File.Delete("remplazo.csv");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminarDelArchivo(lblCod.Text,textBox1.Text,textBox2.Text);
        }
    }
}
