namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gbpersona = new GroupBox();
            label3 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            Nombre = new Label();
            chkOtro = new CheckBox();
            chkFutbol = new CheckBox();
            chkBasquet = new CheckBox();
            dataGridView1 = new DataGridView();
            btnAlta = new Button();
            btnSubir = new Button();
            btnGuardar = new Button();
            Gbpersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Gbpersona
            // 
            Gbpersona.Controls.Add(label3);
            Gbpersona.Controls.Add(txtDni);
            Gbpersona.Controls.Add(label2);
            Gbpersona.Controls.Add(txtApellido);
            Gbpersona.Controls.Add(label1);
            Gbpersona.Controls.Add(txtNombre);
            Gbpersona.Controls.Add(Nombre);
            Gbpersona.Controls.Add(chkOtro);
            Gbpersona.Controls.Add(chkFutbol);
            Gbpersona.Controls.Add(chkBasquet);
            Gbpersona.Location = new Point(28, 33);
            Gbpersona.Name = "Gbpersona";
            Gbpersona.Size = new Size(346, 299);
            Gbpersona.TabIndex = 0;
            Gbpersona.TabStop = false;
            Gbpersona.Text = "Datos persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 182);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Deporte";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(107, 117);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese dni";
            txtDni.Size = new Size(212, 23);
            txtDni.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 117);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "Dni";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(107, 73);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese apellido";
            txtApellido.Size = new Size(212, 23);
            txtApellido.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 76);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre";
            txtNombre.Size = new Size(212, 23);
            txtNombre.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(22, 28);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // chkOtro
            // 
            chkOtro.AutoSize = true;
            chkOtro.Location = new Point(229, 223);
            chkOtro.Name = "chkOtro";
            chkOtro.Size = new Size(50, 19);
            chkOtro.TabIndex = 2;
            chkOtro.Text = "Otro";
            chkOtro.UseVisualStyleBackColor = true;
            // 
            // chkFutbol
            // 
            chkFutbol.AutoSize = true;
            chkFutbol.Location = new Point(147, 223);
            chkFutbol.Name = "chkFutbol";
            chkFutbol.Size = new Size(60, 19);
            chkFutbol.TabIndex = 1;
            chkFutbol.Text = "Futbol";
            chkFutbol.UseVisualStyleBackColor = true;
            // 
            // chkBasquet
            // 
            chkBasquet.AutoSize = true;
            chkBasquet.Location = new Point(53, 223);
            chkBasquet.Name = "chkBasquet";
            chkBasquet.Size = new Size(68, 19);
            chkBasquet.TabIndex = 0;
            chkBasquet.Text = "Basquet";
            chkBasquet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(368, 299);
            dataGridView1.TabIndex = 1;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(375, 387);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 2;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(135, 387);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 3;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(631, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(btnGuardar);
            Controls.Add(btnSubir);
            Controls.Add(btnAlta);
            Controls.Add(dataGridView1);
            Controls.Add(Gbpersona);
            Name = "Form1";
            Text = "Form1";
            Gbpersona.ResumeLayout(false);
            Gbpersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Gbpersona;
        private DataGridView dataGridView1;
        private Button btnAlta;
        private Button btnSubir;
        private Button btnGuardar;
        private Label label3;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private Label Nombre;
        private CheckBox chkOtro;
        private CheckBox chkFutbol;
        private CheckBox chkBasquet;
    }
}
