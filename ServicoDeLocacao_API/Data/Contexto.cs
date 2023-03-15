using Microsoft.EntityFrameworkCore;
using ServicoDeLocacao_API.Models;

namespace ServicoDeLocacao_API.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<RentalCar> RentalCars { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);          
                

            modelBuilder.Entity<RentalCar>()
                .Property(p => p.Nome)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<RentalCar>()
                .Property(p => p.Começo)
                .HasColumnType("Date")
                .IsRequired();

            modelBuilder.Entity<RentalCar>()
                .Property(p => p.Final)
                .HasColumnType("Date")
                .IsRequired();

            modelBuilder.Entity<RentalCar>()
                .Property(p => p.Veiculo)
                .HasMaxLength(50)
                .IsRequired();

            

            


        }
    }
}
