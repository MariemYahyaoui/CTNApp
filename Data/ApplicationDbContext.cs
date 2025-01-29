using CTNApp.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Personnel> Personnels { get; set; }
    public DbSet<Navire> Navires { get; set; }
    public DbSet<Situation> Situations { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Fonction> Fonctions { get; set; }
    public DbSet<Pers_sit> PersSits { get; set; }
    public DbSet<Pers_fct> PersFcts { get; set; }
    public DbSet<Mouvement> Mouvements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pers_sit>()
    .HasKey(ps => new { ps.Matricule, ps.IdSit });

        modelBuilder.Entity<Pers_sit>()
            .HasOne(ps => ps.Personnel)
            .WithMany()
            .HasForeignKey(ps => ps.Matricule);

        modelBuilder.Entity<Pers_sit>()
            .HasOne(ps => ps.Situation)
            .WithMany()
            .HasForeignKey(ps => ps.IdSit);
        modelBuilder.Entity<Pers_fct>()
    .HasKey(pf => new { pf.Matricule, pf.IdFonctionnalite });

        modelBuilder.Entity<Pers_fct>()
            .HasOne(pf => pf.Personnel)
            .WithMany()
            .HasForeignKey(pf => pf.Matricule);

        modelBuilder.Entity<Pers_fct>()
            .HasOne(pf => pf.Fonction)
            .WithMany()
            .HasForeignKey(pf => pf.IdFonctionnalite);


        modelBuilder.Entity<Mouvement>()
        .HasKey(m => new { m.Matricule, m.IdNavire });
        modelBuilder.Entity<Mouvement>()
       .HasOne(m => m.Personnel)
       .WithMany()
       .HasForeignKey(m => m.Matricule);

        modelBuilder.Entity<Mouvement>()
            .HasOne(m => m.Navire)
            .WithMany()
            .HasForeignKey(m => m.IdNavire);
    }
}

