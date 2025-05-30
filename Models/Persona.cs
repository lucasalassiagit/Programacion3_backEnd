using Microsoft.AspNetCore.Hosting.Server;

namespace CrudMVCApp.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Cuit { get; set; }
        public bool Futbol { get; set; }
        public bool Basquet { get; set; }
        public bool Otros { get; set; }
        public char Genero { get; set; }

        //Coleccion de direcciones asociada a la persona (relacion uno a muchos)
        public ICollection<Direccion> Direcciones { get; set; }


        public Persona() { }
    }

    
}
