using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AppWebASPNETcoreTP2.Pages
{
    public class PessoasModel : PageModel
    {
        private readonly ILogger<PessoasModel> _logger;

        public PessoasModel(ILogger<PessoasModel> logger)
        {
            _logger = logger;
        }

        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>(); // Lista de Pessoas

        public void OnGet()
        {
            // Exemplos de inicialização de dados das pessoas
            Pessoas.Add(new Pessoa("João", 30, "123.456.789-10"));
            Pessoas.Add(new Pessoa("Maria", 25, "987.654.321-00"));
            Pessoas.Add(new Pessoa("Pedro", 40, "456.789.123-45"));
        }
    }
}