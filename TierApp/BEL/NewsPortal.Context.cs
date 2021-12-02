

namespace BOL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewsDbContext : DbContext
    {
        public NewsDbContext()
            : base("name=NewsDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<React> Reacts { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
