﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace News_System.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class newsSystem_dbEntities : DbContext
    {
        public newsSystem_dbEntities()
            : base("name=newsSystem_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Icon> Icon { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Post_Tags> Post_Tags { get; set; }
        public virtual DbSet<Social> Social { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CivilStatus> CivilStatus { get; set; }
        public virtual DbSet<Messenger> Messenger { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
    }
}
