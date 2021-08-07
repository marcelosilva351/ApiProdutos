using ApiProdutos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Repository
{
    public interface IProdutoRepository
    {
        void AdicionarProduto(Produto produto);
        IEnumerable<Produto> GetProdutos();
    }
}
