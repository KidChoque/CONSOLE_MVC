using CONSOLE_MVC.Model;
using CONSOLE_MVC.View;

public class ProdutoController
{
Produto produto = new Produto();

ProdutoView produtoView = new ProdutoView();

public void ListarProdutos()
{
    List<Produto> produtos = produto.Ler() ;
    produtoView.Listar(produtos);
}

public void CadastrarProduto()
{
    // chamada para a view que recebe cada objeto a ser inserido no csv
    Produto novoProduto = produtoView.Cadastrar();

// chamada para a model inserir esse objeto no csv
    produto.Inserir(novoProduto);
}

}


