using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabajoD.Models
{
  public class Cliente
        {
            [Key]
            public int ClientesId { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public string Username { get; set; }
            public string Email { get; set; }

        }
}