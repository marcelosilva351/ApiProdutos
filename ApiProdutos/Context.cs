using ApiProdutos.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos
{
    public class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
