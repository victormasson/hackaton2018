﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SP.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbSuiviParcelleEntities1 : DbContext
    {
        public DbSuiviParcelleEntities1()
            : base("name=DbSuiviParcelleEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<EvenementParcelle> EvenementParcelles { get; set; }
        public virtual DbSet<Parcelle> Parcelles { get; set; }
    }
}
