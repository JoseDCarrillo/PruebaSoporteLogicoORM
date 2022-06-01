﻿using System.ComponentModel.DataAnnotations;

namespace PruebaSoporteLogico.Models
{
    public class Vinculacion
    {
        [Key]
        public int IdVinculacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdCargo { get; set; }
        public DateTime FechaRetiro { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int IdEmpleado_Vinculacion { get; set; }
        public Empleado Empleado { get; set; }
        

    }
}
