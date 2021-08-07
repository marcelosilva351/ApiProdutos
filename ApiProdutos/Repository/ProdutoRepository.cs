using ApiProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Context _context;
        public ProdutoRepository(Context context)
        {
            _context = context;
        }
        public void AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return _context.Produtos;
        }
    }
}
