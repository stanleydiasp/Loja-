using System.Reflection.Metadata.Ecma335;

class Produto
{
    // Construtor
    public Produto(int id, string nome, double preco, string categoria, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
        Estoque = estoque;
        Id = id;
    }


    // Propriedades
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Categoria { get; set; }
    public int Estoque { get; set; }

}


class Vitrine
{
    // Lista Produtos
    public List<Produto> Produtos { get; set; } = new();

    
    // Método para carregar os produtos na Lista Produtos
    public void CarregarProduto()
    {
        Produtos.Add(new Produto(1, "Camisa Champion", 55.90, "Masculina", 20));
        Produtos.Add(new Produto(2, "Camisa Monster", 55.90, "Masculina", 10));
        Produtos.Add(new Produto(3, "Camisa Programador", 55.90, "Masculina", 20));
        Produtos.Add(new Produto(4, "Camisa Nike", 55.90, "Masculina", 20));
        Produtos.Add(new Produto(5, "Camisa Adidas", 55.90, "Masculina", 20));
        Produtos.Add(new Produto(6, "Calça Leg", 100, "Masculina", 10));
        Produtos.Add(new Produto(7, "Calça Jeans", 120, "Masculina", 10));
        Produtos.Add(new Produto(8, "Calça Moletom", 55.90, "Feminino", 10));
        Produtos.Add(new Produto(9, "Calça Jeans Azul", 120, "Feminino", 10));
        Produtos.Add(new Produto(10, "Tênis Nike", 55.90, "Feminino", 50));
        Produtos.Add(new Produto(11, "Tênis Adidas", 55.90, "Feminino", 50));
        Produtos.Add(new Produto(12, "Chinelo", 55.90, "Masculina", 20));
    }

    public Produto ObterPorId(int id)
    {
        var produto = Produtos.FirstOrDefault(x => x.Id == id);
        return produto;
    }

}

class Carrinho
{
    public List<Produto> ProdutosNoCarrinho { get; set; } = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        ProdutosNoCarrinho.Add(produto);
        Console.WriteLine($"O produto {produto.Nome} foi adicionado ao carrinho.");
    }

    public void ExibirProdutos()
    {
        Console.WriteLine("Produtos no carrinho:");
        foreach (var produto in ProdutosNoCarrinho)
        {
            Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço {produto.Preco}, Categoria {produto.Categoria}, Estoque {produto.Estoque}");
        }
    }

}

class Pagamento
{
    int p = 1;
    public double CalcularTotal(List<Produto> produtos)
    {
        Console.WriteLine("Se deseja pagar a vista digite [1], se deseja pagar no crédito digite [2]");
        p = Convert.ToInt32(Console.ReadLine());

        double total = 0;
        foreach (var produto in produtos)
        {
            total += produto.Preco;
        }

        if (p == 1)
        {
            Console.WriteLine($"O valor é " + total);
            return total * 0.90;

        } else if (p == 2)
        {
            
            Console.WriteLine($"O valor é " + total);
            return total * 1.05;

        }

        return 0;

    }
}
