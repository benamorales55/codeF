using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst2.Models
{
    public class Universidad
    {
        public  int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Correo { get; set; }
    }
}