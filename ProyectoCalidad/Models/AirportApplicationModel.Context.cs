﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirportApplicationEntities : DbContext
    {
        public AirportApplicationEntities()
            : base("name=AirportApplicationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aeropuerto> Aeropuertos { get; set; }
        public virtual DbSet<Ruta> Rutas { get; set; }
        public virtual DbSet<Vuelo> Vuelos { get; set; }
    }
}
