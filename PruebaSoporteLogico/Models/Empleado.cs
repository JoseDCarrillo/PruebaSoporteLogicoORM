using System.ComponentModel.DataAnnotations;

namespace PruebaSoporteLogico.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public int IdGenero { get; set; }
        public int IdCiudad { get; set; }

        public List<Vinculacion> vinculacions  { get; set; }
    }
}
