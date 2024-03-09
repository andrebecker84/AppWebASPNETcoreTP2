using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AppWebASPNETcoreTP2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Pessoa> Pessoas { get; set; } // Lista de Pessoas

        public void OnGet()
        {
            // Exemplos de inicialização de dados das pessoas
            Pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 30, CPF = "123.456.789-10" },
                new Pessoa { Nome = "Maria", Idade = 25, CPF = "987.654.321-00" },
                new Pessoa { Nome = "Pedro", Idade = 40, CPF = "456.789.123-45" }
            };
        }
    }
}