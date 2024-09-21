using Ex4_ListaDeProdutosRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Ex4_ListaDeProdutosRazor.Pages
{
    public class ProdutoModel : PageModel
    {
        [BindProperty]
        public Produto NovoProduto { get; set; }

        public List<Produto> ListaDeProdutos { get; set; }

        public static List<Produto> Produtos { get; set; } = new List<Produto>
        {
            new Produto("Coca-Cola", 8),
            new Produto("Pão", 4),
            new Produto("Macarrão", 12),
            new Produto("Feijão", 8),
        };

        public void OnGet()
        {
            ListaDeProdutos = Produtos;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                ListaDeProdutos = Produtos;
                return Page();
            }

            Produtos.Add(NovoProduto);
            ListaDeProdutos = Produtos;
            NovoProduto = new Produto();
            return Page();
        }
    }
}
