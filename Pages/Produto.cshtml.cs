using Ex4_ListaDeProdutosRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex4_ListaDeProdutosRazor.Pages
{
    public class ProdutoModel : PageModel
    {
        public List<Produto> Produtos { get; set; }


        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto("Coca-Cola", 8),
                new Produto("Pão", 4),
                new Produto("Macarrão", 12),
                new Produto("Feijão", 8),
            };
        }
    }
}
