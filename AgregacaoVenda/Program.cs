using AgregacaoVenda;

class Program
{
    static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor();
        Comprador comprador = new Comprador(4000);

        Produto prod1 = new Produto("Notebook", 1700);
        Produto prod2 = new Produto("Monitor", 800);
        Produto prod3 = new Produto("Mouse", 250);

        System.Console.WriteLine("\nComprador");
        comprador.MostrarAtributo();
        System.Console.WriteLine("\nVendedor");
        vendedor.MostrarAtributos();

        Venda venda1 = new Venda(comprador, vendedor);
        venda1.AdicionarProduto(prod1);
        venda1.AdicionarProduto(prod2);

        Venda venda2 = new Venda(comprador, vendedor);
        venda2.AdicionarProduto(prod3);

        System.Console.WriteLine("\nVENDA 1\n");
        venda1.MostrarAtributos();

        System.Console.WriteLine("\nVENDA 2\n");
        venda2.MostrarAtributos();

        System.Console.WriteLine("\nComprador");
        comprador.MostrarAtributo();
        System.Console.WriteLine("\nVendedor");
        vendedor.MostrarAtributos();
    }
}