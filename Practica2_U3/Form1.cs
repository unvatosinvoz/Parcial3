using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practica2_U3
{
    public partial class Form1 : Form
    {
        private bool estado1 = false;
        private bool estado2 = false;
        private int _id = -1;
        private string u = "";
        private string p = "";
        private string or = "";
        private int columna = -1;

        public Form1()
        {
            InitializeComponent();
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
                            dataDatos.Rows.Add(c.ToString(), partes[0], partes[1], partes[2]);

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

        private void mnuAArchivo_Click(object sender, EventArgs e)
        {
            estado1 = !estado1;
            Panel_Registro.Visible = estado1;
        }

        private void mnuAMostrar_Click(object sender, EventArgs e)
        {
            estado2 = !estado2;
            Panel_Mostrar.Visible = estado2;
            dataDatos.Rows.Clear();
            cargardatos();
        }

        private void mnuASalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Escribe un nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Escribe un correo")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcorreo.Text))
            {
                txtcorreo.Text = "Escribe un correo";
                txtcorreo.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = "Escribe la edad";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Escribe la edad")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                txtNombre.Text = "Escribe un nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 08) || (e.KeyChar == 46) || (e.KeyChar == 64) || (e.KeyChar == 95) || (e.KeyChar >= 48 && e.KeyChar <= 57))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((txtNombre.Text == "Escribe un nombre") || (txtcorreo.Text == "Escribe un correo") || (string.IsNullOrEmpty(textBox3.Text)))
                {
                    MessageBox.Show("jaja te falta algo");
                }
                else
                {
                    StreamWriter archivo = null;
                    string correo = txtcorreo.Text;
                    string nombre = txtNombre.Text;
                    string edad = textBox3.Text;
                    archivo = File.AppendText("datos.csv");
                    string cadena = correo + "," + nombre + "," + edad;
                    archivo.WriteLine(cadena);
                    archivo.Close();
                    txtNombre.Text = "Escribe un nombre";
                    txtcorreo.Text = "Escribe un correo";
                    textBox3.Text = "Escribe la edad";
                }
            }
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 08))
            {

            }
            else
            {
                e.Handled = true;
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
                                string cadena = partes[0] + "," + partes[1] + "," + partes[2];
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
                                string cadena = partes[0] + "," + partes[1] + ","+ partes[2];
                                aux.WriteLine(cadena);
                                aux.Close();
                            }
                            else
                            {
                            corre:
                                string co = Interaction.InputBox("Escribe un correo", "Agregar correo");
                                if (val.correoelectronico(co) || co.Length == 0)
                                {
                                    if (co.Length == 0)
                                    {
                                        co = u;
                                    }
                                Name:
                                    string us = Interaction.InputBox("Escribe un nombre", "Agregar nombre");
                                    if (val.validarlet(us) || us.Length == 0)
                                    {
                                    age:
                                        if (us.Length == 0)
                                        {
                                            us = or;
                                        }
                                        string ed = Interaction.InputBox("Escribe una edad", "Agregar edad");
                                        if (val.validarnum(ed) || ed.Length == 0)
                                        {
                                            if (ed.Length == 0)
                                            {
                                                ed = p;
                                            }
                                            aux = File.AppendText("remplazo.csv");
                                            string cadena = co + "," + us + "," + ed;
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
                                else
                                {
                                    goto corre;
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

        private void dataDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = e.RowIndex;
            columna = e.ColumnIndex;
            if (_id != -1)
            {
                u = dataDatos.Rows[_id].Cells[1].Value.ToString();
                or = dataDatos.Rows[_id].Cells[2].Value.ToString();
                p = dataDatos.Rows[_id].Cells[3].Value.ToString();
                //MessageBox.Show(u + p);
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un elemento en la lista");
            }
            if (columna == 4)
            {
                modificar();
                dataDatos.Rows.Clear();
                cargardatos();
            }
            else if (columna == 5)
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