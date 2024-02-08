// Historia:

// O cliente possui uma loja de roupas, e precisa controlar as vendas da loja, a loja vende nas seguintes modalidades:
// A vista
// Cartão de credito.
// Para o pagamento a vista a loja permite um desconto de até 10% no dinheiro ou debito.
// Para o pagamento no cartão de credito a loja permite o parcelamento de até 12x do valor da compra, com com acrescimo de 5%.


// Classe Pagamento

// Modalidade 1
// Dinheiro ou Débito (Preço*0.90)

// Modalidade 2
// Cartão de Crédito
// > Parcelado (Preço*1.05 / n)
// > À vista (Preço)




using System.Runtime.InteropServices;

var vitrine = new Vitrine();
vitrine.CarregarProduto();
int p = 1;
var carrinho = new Carrinho();
var pagar = new Pagamento();

//double aVista = pagar.PagamentoAVista(carrinho.ProdutosNoCarrinho);
//double credito = pagar.PagamentoNoCredito(carrinho.ProdutosNoCarrinho);

while (p == 1)
{
    Console.WriteLine("Escolha o número do produto desejado da lista:");
    Console.WriteLine("ID - PRODUTO  -  PREÇO  -  CATEGORIA");

    foreach (var item in vitrine.Produtos)
    {
        Console.WriteLine($" {item.Id} - {item.Nome} - {item.Preco:C2} - {item.Categoria}");
    }

    var codigo = int.Parse(Console.ReadLine());
    var produtoSelecionado = vitrine.ObterPorId(codigo);
    carrinho.AdicionarProduto(produtoSelecionado);

    Console.WriteLine("\n[0] Pagamento  [1] Continuar comprando [2] Exibir meu carrinho");
    p = Convert.ToInt32(Console.ReadLine());



    if (p == 0)
    {
        // Ir para o pagamento
        pagar.CalcularTotal(carrinho.ProdutosNoCarrinho);
        //break;

    }
    else if (p == 1)
    {
        // Continua no Loop
        //continue;
    }
    else if (p == 2)
    {
        carrinho.ExibirProdutos();
    }
    else
    {
        Console.WriteLine("\n\x1b[1;31mInsira um valor válido!\u001b[0m\n");
        Console.WriteLine("\n[0] Pagamento  [1] Continuar comprando [2] Exibir meu carrinho");
        p = Convert.ToInt32(Console.ReadLine());
    }


   // carrinho.ExibirMeuCarrinho();
}



