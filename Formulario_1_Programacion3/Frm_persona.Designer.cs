namespace Formulario_1_Programacion3
{
    partial class Frm_persona
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
            btoGuardar = new Button();
            BtoAlta = new Button();
            chkBasquet = new CheckBox();
            chkFutbol = new CheckBox();
            chkOtros = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Gbpersona = new GroupBox();
            maskedCUIT = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            rbNoBinario = new RadioButton();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            label4 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dataGrid = new DataGridView();
            btoLimpiar = new Button();
            btnEditar = new Button();
            Gbpersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btoGuardar
            // 
            btoGuardar.Location = new Point(684, 284);
            btoGuardar.Margin = new Padding(2, 1, 2, 1);
            btoGuardar.Name = "btoGuardar";
            btoGuardar.Size = new Size(81, 22);
            btoGuardar.TabIndex = 0;
            btoGuardar.Text = "Guardar";
            btoGuardar.UseVisualStyleBackColor = true;
            btoGuardar.Click += btoGuardar_Click;
            // 
            // BtoAlta
            // 
            BtoAlta.Location = new Point(260, 282);
            BtoAlta.Margin = new Padding(2, 1, 2, 1);
            BtoAlta.Name = "BtoAlta";
            BtoAlta.Size = new Size(81, 22);
            BtoAlta.TabIndex = 1;
            BtoAlta.Text = "Alta Persona";
            BtoAlta.UseVisualStyleBackColor = true;
            BtoAlta.Click += BtoAlta_Click;
            // 
            // chkBasquet
            // 
            chkBasquet.AutoSize = true;
            chkBasquet.Location = new Point(103, 166);
            chkBasquet.Margin = new Padding(2, 1, 2, 1);
            chkBasquet.Name = "chkBasquet";
            chkBasquet.Size = new Size(68, 19);
            chkBasquet.TabIndex = 2;
            chkBasquet.Text = "Basquet";
            chkBasquet.UseVisualStyleBackColor = true;
            // 
            // chkFutbol
            // 
            chkFutbol.AutoSize = true;
            chkFutbol.Location = new Point(191, 166);
            chkFutbol.Margin = new Padding(2, 1, 2, 1);
            chkFutbol.Name = "chkFutbol";
            chkFutbol.Size = new Size(60, 19);
            chkFutbol.TabIndex = 3;
            chkFutbol.Text = "Futbol";
            chkFutbol.UseVisualStyleBackColor = true;
            // 
            // chkOtros
            // 
            chkOtros.AutoSize = true;
            chkOtros.Location = new Point(280, 166);
            chkOtros.Margin = new Padding(2, 1, 2, 1);
            chkOtros.Name = "chkOtros";
            chkOtros.Size = new Size(55, 19);
            chkOtros.TabIndex = 4;
            chkOtros.Text = "Otros";
            chkOtros.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 34);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 62);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 23);
            textBox2.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(92, 89);
            txtDni.Margin = new Padding(2, 1, 2, 1);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese Dni";
            txtDni.Size = new Size(266, 23);
            txtDni.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "DNI";
            // 
            // Gbpersona
            // 
            Gbpersona.Controls.Add(maskedCUIT);
            Gbpersona.Controls.Add(label6);
            Gbpersona.Controls.Add(label5);
            Gbpersona.Controls.Add(rbNoBinario);
            Gbpersona.Controls.Add(rbFemenino);
            Gbpersona.Controls.Add(rbMasculino);
            Gbpersona.Controls.Add(label4);
            Gbpersona.Controls.Add(label3);
            Gbpersona.Controls.Add(label2);
            Gbpersona.Controls.Add(label1);
            Gbpersona.Controls.Add(chkOtros);
            Gbpersona.Controls.Add(chkBasquet);
            Gbpersona.Controls.Add(txtDni);
            Gbpersona.Controls.Add(chkFutbol);
            Gbpersona.Controls.Add(txtApellido);
            Gbpersona.Controls.Add(txtNombre);
            Gbpersona.Controls.Add(textBox2);
            Gbpersona.Controls.Add(textBox1);
            Gbpersona.Enabled = false;
            Gbpersona.ForeColor = SystemColors.Desktop;
            Gbpersona.Location = new Point(21, 15);
            Gbpersona.Margin = new Padding(2, 1, 2, 1);
            Gbpersona.Name = "Gbpersona";
            Gbpersona.Padding = new Padding(2, 1, 2, 1);
            Gbpersona.Size = new Size(389, 229);
            Gbpersona.TabIndex = 11;
            Gbpersona.TabStop = false;
            Gbpersona.Text = "Datos Persona";
            // 
            // maskedCUIT
            // 
            maskedCUIT.Location = new Point(92, 120);
            maskedCUIT.Mask = "00-00000000-0";
            maskedCUIT.Name = "maskedCUIT";
            maskedCUIT.Size = new Size(266, 23);
            maskedCUIT.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 128);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 16;
            label6.Text = "CUIT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 199);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Género";
            // 
            // rbNoBinario
            // 
            rbNoBinario.AutoSize = true;
            rbNoBinario.Location = new Point(280, 198);
            rbNoBinario.Margin = new Padding(2, 1, 2, 1);
            rbNoBinario.Name = "rbNoBinario";
            rbNoBinario.Size = new Size(78, 19);
            rbNoBinario.TabIndex = 14;
            rbNoBinario.TabStop = true;
            rbNoBinario.Text = "NoBinario";
            rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(191, 198);
            rbFemenino.Margin = new Padding(2, 1, 2, 1);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 13;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(99, 198);
            rbMasculino.Margin = new Padding(2, 1, 2, 1);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 12;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 166);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Deporte";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(92, 61);
            txtApellido.Margin = new Padding(2, 1, 2, 1);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese apellido";
            txtApellido.Size = new Size(266, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 34);
            txtNombre.Margin = new Padding(2, 1, 2, 1);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre";
            txtNombre.Size = new Size(266, 23);
            txtNombre.TabIndex = 5;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(427, 15);
            dataGrid.Margin = new Padding(2, 1, 2, 1);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 82;
            dataGrid.Size = new Size(338, 229);
            dataGrid.TabIndex = 12;
            // 
            // btoLimpiar
            // 
            btoLimpiar.Location = new Point(30, 282);
            btoLimpiar.Margin = new Padding(2, 1, 2, 1);
            btoLimpiar.Name = "btoLimpiar";
            btoLimpiar.Size = new Size(81, 22);
            btoLimpiar.TabIndex = 13;
            btoLimpiar.Text = "Limpiar";
            btoLimpiar.UseVisualStyleBackColor = true;
            btoLimpiar.Click += btoLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(427, 282);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar Persona";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Frm_persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 325);
            Controls.Add(btnEditar);
            Controls.Add(btoLimpiar);
            Controls.Add(dataGrid);
            Controls.Add(Gbpersona);
            Controls.Add(BtoAlta);
            Controls.Add(btoGuardar);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Frm_persona";
            Text = "Alta Persona";
            Gbpersona.ResumeLayout(false);
            Gbpersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btoGuardar;
        private Button BtoAlta;
        private CheckBox chkBasquet;
        private CheckBox chkFutbol;
        private CheckBox chkOtros;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtDni;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox Gbpersona;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label4;
        private DataGridView dataGrid;
        private Button btoLimpiar;
        private Label label5;
        private RadioButton rbNoBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private MaskedTextBox maskedCUIT;
        private Label label6;
        private Button btnEditar;
    }
}
