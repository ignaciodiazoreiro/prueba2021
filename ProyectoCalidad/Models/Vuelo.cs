//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoCalidad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vuelo
    {
        public int idVueloPK { get; set; }
        public int idRutaFK { get; set; }
        public string codigoAeropuertoFK { get; set; }
        public string codigoVuelo { get; set; }
        public System.DateTime fecha { get; set; }
        public int cantidadRealPasajeros { get; set; }
    
        public virtual Aeropuerto Aeropuerto { get; set; }
        public virtual Ruta Ruta { get; set; }
    }
}
