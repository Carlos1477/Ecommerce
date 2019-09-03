using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabajoD.Models
{
    public class ProductosContext : DbContext
    {
        public ProductosContext(DbContextOptions<ProductosContext> options)
            : base(options)
        { }

        public static object Categoria { get; internal set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }

        public class Productos
        {
            [Key]
            public int ProductoId { get; set; }
            public int Precio { get; set; }
            public string Titulo { get; set; }
            public string Descripcion { get; set; }

            public Categoria Categoria { get; set; }

            public int CategoriaId { get; set; }
          }
      
        public class Clientes
        {
            [Key]
            public int ClientesId { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public string Username { get; set; }
            public string Email { get; set; }

        }

}