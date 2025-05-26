namespace Practica2_U3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Registro = new System.Windows.Forms.Panel();
            this.Panel_Mostrar = new System.Windows.Forms.Panel();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuASalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel_Registro.SuspendLayout();
            this.Panel_Mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Registro
            // 
            this.Panel_Registro.Controls.Add(this.textBox3);
            this.Panel_Registro.Controls.Add(this.txtNombre);
            this.Panel_Registro.Controls.Add(this.txtcorreo);
            this.Panel_Registro.Location = new System.Drawing.Point(28, 31);
            this.Panel_Registro.Name = "Panel_Registro";
            this.Panel_Registro.Size = new System.Drawing.Size(746, 94);
            this.Panel_Registro.TabIndex = 0;
            this.Panel_Registro.Visible = false;
            // 
            // Panel_Mostrar
            // 
            this.Panel_Mostrar.Controls.Add(this.dataDatos);
            this.Panel_Mostrar.Location = new System.Drawing.Point(28, 147);
            this.Panel_Mostrar.Name = "Panel_Mostrar";
            this.Panel_Mostrar.Size = new System.Drawing.Size(746, 278);
            this.Panel_Mostrar.TabIndex = 1;
            this.Panel_Mostrar.Visible = false;
            // 
            // dataDatos
            // 
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Correo,
            this.Nombre,
            this.Edad,
            this.Editar,
            this.Eliminar});
            this.dataDatos.Location = new System.Drawing.Point(0, 0);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.RowHeadersWidth = 51;
            this.dataDatos.RowTemplate.Height = 24;
            this.dataDatos.Size = new System.Drawing.Size(746, 278);
            this.dataDatos.TabIndex = 0;
            this.dataDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDatos_CellClick);
            this.dataDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(32, 38);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(207, 22);
            this.txtcorreo.TabIndex = 0;
            this.txtcorreo.Text = "Escribe un correo";
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(280, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Escribe un nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(531, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Escribe la edad";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAArchivo,
            this.mnuAMostrar,
            this.mnuASalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mnuAArchivo
            // 
            this.mnuAArchivo.Name = "mnuAArchivo";
            this.mnuAArchivo.Size = new System.Drawing.Size(224, 26);
            this.mnuAArchivo.Text = "Agregar";
            this.mnuAArchivo.Click += new System.EventHandler(this.mnuAArchivo_Click);
            // 
            // mnuAMostrar
            // 
            this.mnuAMostrar.Name = "mnuAMostrar";
            this.mnuAMostrar.Size = new System.Drawing.Size(224, 26);
            this.mnuAMostrar.Text = "Mostrar";
            this.mnuAMostrar.Click += new System.EventHandler(this.mnuAMostrar_Click);
            // 
            // mnuASalir
            // 
            this.mnuASalir.Name = "mnuASalir";
            this.mnuASalir.Size = new System.Drawing.Size(224, 26);
            this.mnuASalir.Text = "Salir";
            this.mnuASalir.Click += new System.EventHandler(this.mnuASalir_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Practica2_U3.Properties.Resources.istockphoto_1265891330_1024x1024;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Practica2_U3.Properties.Resources.istockphoto_1265891330_1024x1024__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Practica2_U3.Properties.Resources.istockphoto_1265891330_1024x1024;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Practica2_U3.Properties.Resources.istockphoto_1265891330_1024x1024__1_;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_Mostrar);
            this.Controls.Add(this.Panel_Registro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_Registro.ResumeLayout(false);
            this.Panel_Registro.PerformLayout();
            this.Panel_Mostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Registro;
        private System.Windows.Forms.Panel Panel_Mostrar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAMostrar;
        private System.Windows.Forms.ToolStripMenuItem mnuASalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}

