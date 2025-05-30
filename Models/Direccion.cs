namespace CrudMVCApp.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        // Fk clase persona
        public int PersonaId {  get; set; }

        // Propiedad de navegación 
        public Persona Persona { get; set; }

        public Direccion() { }
    }
}
