﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DG.DentneD.Model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dentnedEntities : DbContext
    {
        public dentnedEntities()
            : base("name=dentnedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<addressestypes> addressestypes { get; set; }
        public virtual DbSet<appointments> appointments { get; set; }
        public virtual DbSet<computedlines> computedlines { get; set; }
        public virtual DbSet<contactstypes> contactstypes { get; set; }
        public virtual DbSet<doctors> doctors { get; set; }
        public virtual DbSet<estimates> estimates { get; set; }
        public virtual DbSet<estimatesfooters> estimatesfooters { get; set; }
        public virtual DbSet<estimateslines> estimateslines { get; set; }
        public virtual DbSet<invoices> invoices { get; set; }
        public virtual DbSet<invoicesfooters> invoicesfooters { get; set; }
        public virtual DbSet<invoiceslines> invoiceslines { get; set; }
        public virtual DbSet<medicalrecordstypes> medicalrecordstypes { get; set; }
        public virtual DbSet<patients> patients { get; set; }
        public virtual DbSet<patientsaddresses> patientsaddresses { get; set; }
        public virtual DbSet<patientsattachments> patientsattachments { get; set; }
        public virtual DbSet<patientsattachmentstypes> patientsattachmentstypes { get; set; }
        public virtual DbSet<patientsattributes> patientsattributes { get; set; }
        public virtual DbSet<patientsattributestypes> patientsattributestypes { get; set; }
        public virtual DbSet<patientscontacts> patientscontacts { get; set; }
        public virtual DbSet<patientsmedicalrecords> patientsmedicalrecords { get; set; }
        public virtual DbSet<patientsnotes> patientsnotes { get; set; }
        public virtual DbSet<patientstreatments> patientstreatments { get; set; }
        public virtual DbSet<payments> payments { get; set; }
        public virtual DbSet<paymentstypes> paymentstypes { get; set; }
        public virtual DbSet<reports> reports { get; set; }
        public virtual DbSet<rooms> rooms { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<taxes> taxes { get; set; }
        public virtual DbSet<taxesdeductions> taxesdeductions { get; set; }
        public virtual DbSet<treatments> treatments { get; set; }
        public virtual DbSet<treatmentsprices> treatmentsprices { get; set; }
        public virtual DbSet<treatmentspriceslists> treatmentspriceslists { get; set; }
        public virtual DbSet<treatmentstypes> treatmentstypes { get; set; }
    }
}
