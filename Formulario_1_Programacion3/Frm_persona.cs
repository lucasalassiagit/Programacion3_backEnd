using Formulario_1_Programacion3;
using Microsoft.VisualBasic.Logging;
using System;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Formulario_1_Programacion3
{
    public partial class Frm_persona : Form
    {
        private Persona personaEdicion = null;
        private List<Persona> _listPersona = new List<Persona>();

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
                if(personaEdicion == null)
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

                else
                {
                    personaEdicion.Nombre = txtNombre.Text;
                    personaEdicion.Apellido = txtApellido.Text;
                    personaEdicion.Futbol = chkFutbol.Checked ? 'F' : ' ';
                    personaEdicion.Basquet = chkBasquet.Checked ? 'B' : ' ';
                    personaEdicion.Otros = chkOtros.Checked ? 'O' : ' ';
                    chkOtros.Checked = personaEdicion.Otros == 'O' ? true : false;
                    personaEdicion.Genero = ObtenerValor();
                    
                    GuardarDatos();
                    LimpiarCampos();
                }
                
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe Seleccionar una persona de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dataGrid.SelectedRows[0];
            string cuitSeleccionado = fila.Cells["Cuit"].Value.ToString();
            personaEdicion = _listPersona.FirstOrDefault(p => p.Cuit == cuitSeleccionado);

            
            if (personaEdicion != null)
            {
                txtNombre.Text = personaEdicion.Nombre;
                txtApellido.Text = personaEdicion.Apellido;
                txtDni.Text = personaEdicion.Dni.ToString();
                maskedCUIT.Text = personaEdicion.Cuit;
                chkFutbol.Checked = personaEdicion.Futbol == 'F' ? true : false;
                chkBasquet.Checked = personaEdicion.Basquet == 'B' ? true : false;
                chkOtros.Checked = personaEdicion.Otros == 'O' ? true : false;
                rbMasculino.Checked = personaEdicion.Genero == 'M' ? true : false;
                rbFemenino.Checked = personaEdicion.Genero == 'F' ? true : false;
                rbNoBinario.Checked = personaEdicion.Genero == 'N' ? true : false;

                maskedCUIT.ReadOnly = true;
                txtDni.ReadOnly = true;
            }
        }

        private void btoLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}







