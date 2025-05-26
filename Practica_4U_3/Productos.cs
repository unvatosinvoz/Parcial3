using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Practica_4U_3
{
    public partial class Productos : Form
    {
        private int _id = -1;
        private string u = "";
        private string p = "";
        private string j = "";
        private int columna = -1;
        private string im = "";
        private string rutaimagenlocal = "", imagenlocal = "";
        private string codigoArchivo;
        List<string> img = new List<string>();
        public Productos()
        {
            InitializeComponent();
            cargardatos();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }
        private void cargardatos()
        {
            if (File.Exists("productos.csv"))
            {
                StreamReader streamReader = File.OpenText("productos.csv");
                string renglon = "";
                int c = 0;
                do
                {
                    try
                    {
                        renglon = streamReader.ReadLine();
                        if (renglon != null)
                        {
                            string[] partes = renglon.Split(',');
                            c++;
                            dataGridView1.Rows.Add(partes[0], partes[1], partes[2], Image.FromFile(partes[3]), partes[3]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error", ex.Message);
                    }
                } while (renglon != null);
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("No existen datos guardados");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter streamwriter;
            string productos = "productos.csv";
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Te faltan datos");
            }
            else
            {
                string codigo = textBox1.Text.Substring(0, 2);
                int sistema = DateTime.Now.Hour;
                codigo += sistema;
                streamwriter = File.AppendText(productos);
                streamwriter.WriteLine(codigo + "," + textBox1.Text + "," + textBox2.Text + "," + rutaimagenlocal);
                streamwriter.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                pictureBox1.Image = null;
                dataGridView1.Rows.Clear();
                cargardatos();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            String rutaImagen = "";
            String rutaCarpeta = @"\imagenes";
            String rutaRaiz = @"imagenes";
            String ruta = "";
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Escribe el producto primero", "Ventana");
            }
            else
            {
                int ssistema = DateTime.Now.Second;
                String nombreImagen = "";
                nombreImagen = "img" + ssistema.ToString() + textBox1.Text + ".png";
                ofd.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    String[] listaDirectorios = Directory.GetDirectories(rutaRaiz);
                    ruta = ofd.FileName;
                    System.IO.File.Copy(ruta, listaDirectorios[0] + nombreImagen, true);
                    pictureBox1.Image = Image.FromFile(listaDirectorios[0] + nombreImagen);
                    rutaimagenlocal = listaDirectorios[0] + nombreImagen;
                }

                button2.Enabled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = e.RowIndex;
            columna = e.ColumnIndex;
            if (_id != -1)
            {
                u = dataGridView1.Rows[_id].Cells[0].Value.ToString();
                p = dataGridView1.Rows[_id].Cells[1].Value.ToString();
                j = dataGridView1.Rows[_id].Cells[2].Value.ToString();
                im = dataGridView1.Rows[_id].Cells[4].Value.ToString();
                imagenlocal = dataGridView1.Rows[_id].Cells[4].Value.ToString();
                img.Clear();
                img.Add(dataGridView1.Rows[_id].Cells[4].Value.ToString());
                //MessageBox.Show(u + p);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_id != -1 && img.Count > 0)
            {
                string rutaRelativa = img[0];
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaRelativa);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value is Image imagenCelda)
                    {
                        imagenCelda.Dispose();
                    }
                }
                if (File.Exists(rutaCompleta))
                {
                    try
                    {
                        File.Delete(rutaCompleta);
                        MessageBox.Show("a");
                        eliminarDelArchivo(_id);
                        dataGridView1.Rows.RemoveAt(_id);
                        _id = -1;
                        img.Clear();
                        codigoArchivo = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar(codigoArchivo,p,j,im);
            modificar.ShowDialog();
        }

        private void eliminarDelArchivo(int _id)
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
                        if (!partes[0].Equals(codigoArchivo))
                        {
                            aux = File.AppendText("remplazo.csv");
                            string cadena = partes[0] + "," + partes[1] + "," + partes[2] + "," + partes[3];
                            aux.WriteLine(cadena);
                            aux.Close();
                        }
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
            cargardatos();
        }
    }
}