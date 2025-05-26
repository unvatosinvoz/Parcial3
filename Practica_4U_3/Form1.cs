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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            revisarImagen();
            crearusuario();
        }
        StreamWriter streamwriter;
        private void crearusuario()
        {
            string usuarios = "usuarios.csv";
            if (File.Exists(usuarios))
            {

            }
            else
            {   
                streamwriter = File.AppendText(usuarios);
                streamwriter.WriteLine("admin,12345,administrador");
                streamwriter.Close();
            }
        }
        private void revisarImagen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string rutaImagen = "";
            string rutaCarpeta = @"\imagenes";
            string rutaRaiz = @"imagenes";
            string ruta = "";
            Random random = new Random();
            int nombreArchivo = random.Next(1, 1000);
            if (!Directory.Exists(rutaRaiz))
            {
                Directory.CreateDirectory(rutaRaiz);
                Directory.CreateDirectory(rutaRaiz+rutaCarpeta);
                string[] listaDirectorios = Directory.GetDirectories(rutaRaiz);
                ofd.Filter = "JPG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofd.FileName;
                    System.IO.File.Copy(ruta, listaDirectorios[0] + "banner" + ".png", true);
                    img.Image = Image.FromFile(listaDirectorios[0] + "banner" + ".png");
                }
            }
            else
            {
                string[] listaDirectorios = Directory.GetDirectories(rutaRaiz);
                img.Image = Image.FromFile(listaDirectorios[0] + "banner" + ".png");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarios = "usuarios.csv";
            string dato = "";
            string cu = textBox2.Text;
            string cp = textBox1.Text;
            bool encontro = Focused;
            if (cu.Length == 0 || cp.Length == 0)
            {
                MessageBox.Show("Falta usuario o contraseña");
            }
            else
            {
                if (File.Exists(usuarios))
                {
                    StreamReader sr = File.OpenText(usuarios);
                    do
                    {
                        dato = sr.ReadLine();
                        if (dato != null)
                        {
                            int p = dato.IndexOf(",");
                            int p2 = dato.IndexOf(",",p+1);
                            string u = dato.Substring(0, p);
                            string pa = dato.Substring(p+1,p2-p-1);
                            if (u.Equals(cu) && pa.Equals(cp))
                            {
                                encontro = true;
                                break;
                            }
                        }
                    } while (dato != null);
                    sr.Close();
                    if (encontro) {
                        this.Hide();
                        Productos productos = new Productos();
                        productos.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("xD");
                }
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
