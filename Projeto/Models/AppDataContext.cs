using Microsoft.EntityFrameworkCore;
using Projeto.Models;




public class AppDataContext : DbContext

{

    public DbSet<Aluno> Alunos { get; set; }

    public DbSet<Imc> Imcs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=pedro.db");
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Aluno>()
            .HasKey(a => a.AlunoId);

        modelBuilder.Entity<Imc>()
            .HasKey(i => i.ImcId);

        modelBuilder.Entity<Imc>()
            .HasOne(i => i.Aluno)
            .WithMany(a => a.Imcs)
            .HasForeignKey(i => i.Aluno)
            .OnDelete(DeleteBehavior.Cascade);
    }
}




