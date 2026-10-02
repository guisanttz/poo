using AgregacaoVenda;

class Program
{
    static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor();
        Comprador comprador = new Comprador(2500); // 2500 de verba
        Produto prod1 = new Produto("Notebook", 1700);
        Produto prod2 = new Produto("Monitor", 800);
        Produto prod3 = new Produto("Mouse", 250);
        
    }
}