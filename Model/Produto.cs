using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONSOLE_MVC.Model
{
    public class Produto
    {
        // Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // Caminho da pasta e do arquivo definido 
        private const string PATH = "Database/Produto.csv";

       public Produto()

    {
        string pasta = PATH.Split("/")[0];
        if (!Directory.Exists(pasta))
        {
            Directory.CreateDirectory(pasta);
        }
        if (!File.Exists(PATH))
        {
            File.Create(PATH);
            
        }
    }

    public List<Produto> Ler()
    {
        List<Produto> produtos = new List<Produto>();

        string[] linhas = File.ReadAllLines(PATH);


       foreach (var item in linhas)
       {
        string[] atributos = item.Split(";");

      Produto p = new Produto();

      p.Codigo = int.Parse(atributos[0]);
      p.Nome = atributos[1];
      p.Preco = float.Parse(atributos[2]);

      produtos.Add(p);

       }

        return produtos;
    }



// método para preparar a linha do csv

public string PrepararCSV(Produto p)
{
    return $"{p.Codigo};{p.Nome};{p.Preco}";
}

public void Inserir(Produto p)
{
    // array que vai armazenar as linhas(cada "objeto")
    string[] linhas = {PrepararCSV(p)};

    // vai até o arquivo e insere todas as linhas
    File.AppendAllLines(PATH,linhas);
}
    }
}

