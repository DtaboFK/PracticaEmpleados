using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Entities
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required]
        public string Contactto { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public bool Estado { get; set; }

    }
}
