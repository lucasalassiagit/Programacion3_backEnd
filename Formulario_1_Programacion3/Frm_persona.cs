using Formulario_1_Programacion3;
using Microsoft.VisualBasic.Logging;
using System;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formulario_1_Programacion3
{
    public partial class Frm_persona : Form
    {
        private List<Persona> _listPersona = new List<Persona> ();
        
        public Frm_persona()
        {
            InitializeComponent();
        }

        private void BtoAlta_Click(object sender, EventArgs e)
        {
            Gbpersona.Enabled = true;

        }

        private void btoGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var persona = new Persona
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = Convert.ToInt32(txtDni.Text),
                    Cuit = maskedCUIT.Text,
                    Futbol = chkFutbol.Checked ? 'F' : ' ',
                    Basquet = chkBasquet.Checked ? 'B' : ' ',
                    Otros = chkOtros.Checked ? 'O' : ' ',
                    Genero = ObtenerValor(),
                };
                _listPersona.Add(persona);
                GuardarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            maskedCUIT.Clear();
            chkFutbol.Checked = false;
            chkBasquet.Checked = false;
            chkOtros.Checked = false;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbNoBinario.Checked = false;
        }

        private void GuardarDatos()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = _listPersona.Select(p => new
            {
                p.Nombre,
                p.Apellido,
                p.Dni,
                p.Cuit
            }).ToList();
        }

        private char ObtenerValor()
        {
            if (rbMasculino.Checked)
            {
                return 'M';
            }
            if (rbFemenino.Checked)
            {
                return 'F';
            }
            if (rbNoBinario.Checked)
            {
                return 'N';
            }
            return ' ';
        }

    }
}







