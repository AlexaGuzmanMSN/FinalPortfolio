﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalPortfolio3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalPortfolio2Entities : DbContext
    {
        public FinalPortfolio2Entities()
            : base("name=FinalPortfolio2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Screenshot> Screenshots { get; set; }
    }
}
