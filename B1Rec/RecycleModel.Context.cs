//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B1Rec
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecycleEntities : DbContext
    {
        public RecycleEntities()
            : base("name=RecycleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<Blerjet> Blerjets { get; set; }
        public virtual DbSet<pazariDitor> pazariDitors { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
