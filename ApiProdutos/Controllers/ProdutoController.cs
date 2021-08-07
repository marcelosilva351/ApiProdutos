using ApiProdutos.Model;
using ApiProdutos.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoRepository produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        [HttpPost]
        public void AdicionarProduto(Produto produto)
        {
            produtoRepository.AdicionarProduto(produto);
        }

        [HttpGet]
        public IEnumerable<Produto> GetProdutos()
        {
            return produtoRepository.GetProdutos();
        }



    }
}
