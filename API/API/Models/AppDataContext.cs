using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class AppDataContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Imc> Imcs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=alexandre.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().HasData(
            new Aluno { AlunoId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", Nome = "Pedro", Sobrenome = "Pereira" },
            new Aluno { AlunoId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", Nome = "Felipe", Sobrenome = "Pereira" },
            new Aluno { AlunoId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", Nome = "Pedro", Sobrenome = "bojanovsky"}
        );
        modelBuilder.Entity<Imc>().HasData(
            new Imc { ImcId = "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",  AlunoId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd", Altura = 1.75, Peso = 87 },
            new Imc { ImcId = "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",  AlunoId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d", Altura = 1.68, Peso = 53 },
            new Imc { ImcId = "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",  AlunoId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e", Altura = 1.83, Peso = 93 }
        );
    }
}
