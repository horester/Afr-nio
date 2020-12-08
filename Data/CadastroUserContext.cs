using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Afranio.Models;

namespace Afranio.Data
{
    public class CadastroUserContext : DbContext
    {
        public CadastroUserContext(DbContextOptions<CadastroUserContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastro> Cadastros { get; set; }
    }
}