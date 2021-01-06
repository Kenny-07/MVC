using System.Collections.Generic;
using MVC.Models;
using MVC.View;
namespace MVC.Controllers
{
    public class ProdutoController
    {
    Produto produto = new Produto();  
    ProdutoView produtoView = new ProdutoView();

    public void ListarProdutos()
        {
           produtoView.Listar(produto.Ler());
        }
    }
}