using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Parcial3_U3
{
    public partial class muestre : Form
    {
        private int _id = -1;
        private string u = "";
        private string p = "";
        private int columna = -1;
        public muestre()
        {
            InitializeComponent();
            cargardatos();
        }
        private void cargardatos()
        {
            if (File.Exists("datos.csv"))
            {
                StreamReader streamReader = File.OpenText("datos.csv");
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
                            dataDatos.Rows.Add(c.ToString(), partes[0], partes[1]);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                } while (renglon != null);
                streamReader.Close();
            }
            else
            {
                MessageBox.Show("No existen datos guardados");
            }
        }
        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void modificar()
        {
            if (_id != -1)
            {
                dataDatos.Rows.RemoveAt(_id);
                StreamReader streamReader = File.OpenText("datos.csv");
                string renglon = "";
                StreamWriter aux = null;
                int c = 0;
                validaciones val = new validaciones();
                do
                {
                    try
                    {
                        renglon = streamReader.ReadLine();
                        if (renglon != null)
                        {
                            string[] partes = renglon.Split(',');
                            if (!partes[0].Equals(u))
                            {
                                aux = File.AppendText("remplazo.csv");
                                string cadena = partes[0] + "," + partes[1];
                                aux.WriteLine(cadena);
                                aux.Close();
                            }
                            else
                            {
                            Name:
                                string us = Interaction.InputBox("Escribe un nombre", "Agregar nombre");
                                if (val.validarlet(us) || us.Length == 0)
                                {
                                age:
                                    if (us.Length == 0)
                                    {
                                        us = u;
                                    }
                                    string ed = Interaction.InputBox("Escribe una edad", "Agregar edad");
                                    if (val.validarnum(ed) || ed.Length == 0)
                                    {
                                        if (ed.Length == 0)
                                        {
                                            ed = p;
                                        }
                                        aux = File.AppendText("remplazo.csv");
                                        string cadena = us + "," + ed;
                                        aux.WriteLine(cadena);
                                        aux.Close();
                                    }
                                    else
                                    {
                                        goto age;
                                    }
                                }
                                else
                                {
                                    goto Name;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                } while (renglon != null);
                aux.Close();
                streamReader.Close();
                File.Delete("datos.csv");
                if (File.Exists("remplazo.csv"))
                {
                    File.Move("remplazo.csv", "datos.csv");
                }

            }
        }

        private void eliminar()
        {
            if (_id != -1)
            {
                dataDatos.Rows.RemoveAt(_id);
                StreamReader streamReader = File.OpenText("datos.csv");
                string renglon = "";
                StreamWriter aux = null;
                int c = 0;
                do
                {
                    try
                    {
                        renglon = streamReader.ReadLine();
                        if (renglon != null)
                        {
                            string[] partes = renglon.Split(',');
                            if (!partes[0].Equals(u))
                            {
                                aux = File.AppendText("remplazo.csv");
                                string cadena = partes[0] + "," + partes[1];
                                aux.WriteLine(cadena);
                                aux.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                } while (renglon != null);
                streamReader.Close();
                File.Delete("datos.csv");
                if (File.Exists("remplazo.csv"))
                {
                    File.Move("remplazo.csv", "datos.csv");
                }
            }
        }
        private void dataDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = e.RowIndex;
            columna = e.ColumnIndex;
            if (_id != -1)
            {
                u = dataDatos.Rows[_id].Cells[1].Value.ToString();
                p = dataDatos.Rows[_id].Cells[2].Value.ToString();
                //MessageBox.Show(u + p);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un elemento en la lista");
            }
            if (columna == 3)
            {
                modificar();
                dataDatos.Rows.Clear();
                cargardatos();
            }
            else if (columna == 4)
            {
                MessageBoxButtons boton = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult Respuesta = MessageBox.Show("Seguro que quieres eliminarlo", "Alerta", boton, icon);
                if (Respuesta == DialogResult.Yes)
                {
                    eliminar();
                    dataDatos.Rows.Clear();
                    cargardatos();
                }
            }
        }
    }
}
