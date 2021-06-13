using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroConDetalle.Models
{
    public class Prestamos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar Vacío el campo 'PrestamoId'")]
        [Range(0, 100, ErrorMessage = "El campo 'PrestamoId' no puede ser 0 o (mayor a 1000).")]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'PersonaId'")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Fecha")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Concepto'")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacío el campo 'Monto'")]
        public double Monto { get; set; }
        public double Balance { get; set; }

        [ForeignKey("PrestamoId")]
        public List<MorasDetalle> Detalle { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = "";
            Monto = 0;
            Balance = 0;
            Detalle = new List<MorasDetalle>();
        }

    }
}
