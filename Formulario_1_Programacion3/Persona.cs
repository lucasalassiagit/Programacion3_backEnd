using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_1_Programacion3
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string cuit;
        private char basquet;
        private char futbol;
        private char otros;
        private char genero;

        public Persona()
        {
            
        }

        public Persona(string nombre, string apellido, int dni, string cuit, char basquet, char futbol, char otros, char genero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.cuit = cuit;
            this.basquet = basquet;
            this.futbol = futbol;
            this.otros = otros;
            this.genero = genero;
        }

        public string Nombre { get => nombre; 
                               set => nombre = value.Trim(); }
        public string Apellido { get => apellido; 
                                 set => apellido = value.Trim(); }
        public int Dni { get => dni; 
                         set => dni = Convert.ToInt32(value); }
        public string Cuit { get => cuit;
                             set
                             {
                                if (!Validaciones.EsCUITValido(value)){
                                    throw new ArgumentException("CUIT invalido");
                                }
                                cuit = value;
                             }
        }
        public char Basquet { get => basquet; set => basquet = value; }
        public char Futbol { get => futbol; set => futbol = value; }
        public char Otros { get => otros; set => otros = value; }
        public char Genero { get => genero; set => genero = value; }

    }
}
