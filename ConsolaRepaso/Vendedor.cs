using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsolaRepaso
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }
        [NotMapped]
        public int EdadAños
        {
            get
            {
                return DateTime.Now.Year - Nacimiento.Year;
            }
        }
        public string CiudadDondeVive { get; set; }
        public string Saludar()
        {
            return $" Hola soy {Nombre} y soy un vendedor  de artefactos";
        }
        public string Cobrar()
        {
            return $" Si a una persona le gusta el producto yo soy el que cobra ";
        }
        public string DarVueltos()
        {
            return $" y ademas  soy el que da los vueltos. ";
        }

    }
}