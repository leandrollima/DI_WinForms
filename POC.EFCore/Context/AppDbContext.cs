using Microsoft.EntityFrameworkCore;
using POC.EFCore.Model;

namespace POC.EFCore.Context;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseNpgsql("Host=IV-SrvDoc-dev-1;Database=Maestro_IMC;Username=postgres;Password=Royale");

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("tablefunc");

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.IdCategorie).HasName("categorie_pkey");

            entity.ToTable("categorie");

            entity.Property(e => e.IdCategorie).HasColumnName("id_categorie");
           
            entity.Property(e => e.Identification)
                .HasMaxLength(40)
                .HasColumnName("identification");
        });

        OnModelCreatingPartial(modelBuilder);
    }

}
