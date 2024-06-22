using System;
using System.Collections.Generic;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ItemBiblioteca livro1, livro2, revista1;
                Biblioteca biblioteca = new Biblioteca();
                List<ItemBiblioteca> adicionarNaLista = new List<ItemBiblioteca>();

                // Arquivo
                Arquivo arquivo = new Arquivo("biblioteca");

                // Inicializar os objetos. Aqui eu utilizo o polimofismo para referênciar a  ItemBiblioteca, facilitando a manipulação de diferente tipos de itens;
                livro1 = new Livro { Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", AnoDePublicacao = 1954 };
                livro2 = new Livro { Titulo = "1984", Autor = "George Orwell", AnoDePublicacao = 1954 };
                revista1 = new Revista { Titulo = "Vogue", Autor = "Arthur Baldwin Turnure", AnoDePublicacao = 1892 };

                // Adicionar itens à lista
                adicionarNaLista.Add(livro1);
                adicionarNaLista.Add(livro2);
                adicionarNaLista.Add(revista1);

                // Salvar itens no arquivo
                arquivo.GravarMensagem($"{livro1.Titulo}, {livro1.Autor}, {livro1.AnoDePublicacao}");
                arquivo.GravarMensagem($"{livro2.Titulo}, {livro2.Autor}, {livro2.AnoDePublicacao}");
                arquivo.GravarMensagem($"{revista1.Titulo}, {revista1.Autor}, {revista1.AnoDePublicacao}");

                // Exibir o conteúdo do arquivo
                Console.WriteLine("Conteúdo do arquivo:");
                arquivo.ExibirArquivo();

                // Adicionar itens à biblioteca
                biblioteca.AdicionarItem(livro1);
                biblioteca.AdicionarItem(livro2);
                biblioteca.AdicionarItem(revista1);

                // Exibir todos os itens
                Console.WriteLine("\nItens na biblioteca:");
                biblioteca.ExibirItens();

                // Realizar empréstimos
                Console.WriteLine("\nRealizando empréstimos:");
                biblioteca.RealizarEmprestimo(livro1);
               

                // Devolução
                Console.WriteLine("\nItem devolvido à biblioteca:");
                livro1.Devolver();

                // Ler itens do arquivo
                LerItens(adicionarNaLista, arquivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro no sistema: " + ex.Message);
            }
        }

        static void LerItens(List<ItemBiblioteca> adicionarNaLista, Arquivo arquivo)
        {
            adicionarNaLista.Clear();
            string[] linhas = arquivo.LerTodasAsLinhas();
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                if (partes.Length == 3)
                {
                    int anoDePublicacao = int.Parse(partes[2].Trim());
                    if (partes[0].Trim() == "Vogue") // Exemplo de distinção entre livro e revista
                    {
                        ItemBiblioteca revista = new Revista
                        {
                            Titulo = partes[0].Trim(),
                            Autor = partes[1].Trim(),
                            AnoDePublicacao = anoDePublicacao
                        };
                        adicionarNaLista.Add(revista);
                    }
                    else
                    {
                        ItemBiblioteca livro = new Livro
                        {
                            Titulo = partes[0].Trim(),
                            Autor = partes[1].Trim(),
                            AnoDePublicacao = anoDePublicacao
                        };
                        adicionarNaLista.Add(livro);
                    }
                }
            }
        }
    }
}
