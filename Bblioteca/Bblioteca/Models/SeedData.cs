using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bblioteca.Data;
using System;
using System.Linq;

namespace Bblioteca.Models;

public class SeedData
{
    public static void Initialize (IServiceProvider serviceProvider)
    {
        using (var context = new BbliotecaContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<BbliotecaContext>>()))
        {
            if(context.Livro.Any())
            {
                return;
            }
            context.Livro.AddRange(
                new Livro()
                {
                    Titulo = "Pai Rico Pai Pobre",
                    Autor = "Robert Kiyosaki",
                    Area = "Financas",
                    Ano = 1997,
                    Editora = "Alta Books"
                },
                new Livro()
                {
                    Titulo = "Os segredos da mente milionaria",
                    Autor = "T. Harv Eker",
                    Area = "Autoajuda",
                    Ano = 2005,
                    Editora = "Editora"
                },
                new Livro()
                {
                    Titulo = "Do mil ao milhão: Sem cortar o cafezinho",
                    Autor = "Thiago Nigro",
                    Area = "Financas",
                    Ano = 2018,
                    Editora = "Casa dos livros"
                });
        context.SaveChanges();
        }
    }
}
