using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Config;
using MiTiendaPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Data
{
    public class MiTiendaPOSContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }

        public MiTiendaPOSContext() { }

        public MiTiendaPOSContext(DbContextOptions<MiTiendaPOSContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {//Reemplazamos la cadena de conexión que tenia definida anteriormente
            if (!options.IsConfigured)
            {
                options.UseSqlServer(ConfiguracionApp.ObtenerCadenaConexion());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Productos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.Detalles)
                .HasForeignKey(dv => dv.VentaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany()
                .HasForeignKey(dv => dv.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nombre = "Bebidas" },
                new Categoria { Id = 2, Nombre = "Abarrotes" },
                new Categoria { Id = 3, Nombre = "Limpieza" });

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, NombreUsuario = "Amin", Rol = "administrador" });

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Soda 600ml", CategoriaId = 1, PrecioUnitario = 0.90m, Stock = 48, Activo = true },
                new Producto { Id = 2, Nombre = "Detergente MAXI SPUMA", CategoriaId = 3, PrecioUnitario = 2.50m, Stock = 24, Activo = true },
                new Producto { Id = 3, Nombre = "Frijol Seda", CategoriaId = 2, PrecioUnitario = 3.25m, Stock = 48, Activo = true },
                new Producto { Id = 4, Nombre = "Jabón de Lavar", CategoriaId = 3, PrecioUnitario = 1.75m, Stock = 36, Activo = true },
                new Producto { Id = 5, Nombre = "Arroz", CategoriaId = 2, PrecioUnitario = 1.50m, Stock = 60, Activo = true },
                new Producto { Id = 6, Nombre = "Soda 1.5L", CategoriaId = 1, PrecioUnitario = 1.50m, Stock = 36, Activo = true }
                );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Consumidor Final" },
                new Cliente { Id = 2, Nombre = "Maria Lopez", Telefono = "7000-0000" });
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 2, NombreUsuario = "Cajero`1", Rol = "Cajero" });
        }
    }
}
