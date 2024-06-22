using System;
using System.IO;
using System.Text;

public class Arquivo
{
    private string _nome;

    public string Mensagem { get; set; }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _nome = value;
            }
        }
    }

    public Arquivo(string nome)
    {
        Nome = nome;

    }//Eu vi que o using é uma instrução ideal para se usar nesse caso,
     //pois garante o StreamWriter e StreamReader seja fechando corretamente após salvar o arquivo,  evitando possíveis problemas no arquivo. 
     //Descobrir o using após um problema ao enviar o arquivo.

    public void GravarMensagem(string mensagem)
    {
        
        using (StreamWriter _writer = new StreamWriter("C:\\Users\\lukel\\Downloads\\New folder\\" + Nome + ".txt", true, Encoding.UTF8))
        {
            _writer.WriteLine(mensagem);
        }
    }

    public void LerArquivo()
    {
        using (StreamReader _reader = new StreamReader("C:\\Users\\lukel\\Downloads\\New folder\\" + Nome + ".txt"))
        {
            string linha;
            while ((linha = _reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }

    public string[] LerTodasAsLinhas()
    {
        return File.ReadAllLines("C:\\Users\\lukel\\Downloads\\New folder\\" + Nome + ".txt");
    }


    public void ExibirArquivo()
    {
        using (StreamReader reader = new StreamReader("C:\\Users\\lukel\\Downloads\\New folder\\" + Nome + ".txt"))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
