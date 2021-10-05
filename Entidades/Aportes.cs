using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Danilo_20190266.Entidades
{
    public class Aportes
    {
        [Key]
        public int AporteID { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public String Persona { get; set; }
        public String Concepto { get; set; }
        public int Monto { get; set; }
    }
}
