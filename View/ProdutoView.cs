using CONSOLE_MVC.Model;

namespace CONSOLE_MVC.View

{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            Console.Clear();
            foreach (var item in produto)
            {
                Console.WriteLine($" Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");

            }
        }

        public Produto Cadastrar()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Informe o código do produto:");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preço do produto:");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}