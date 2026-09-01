using ConstrutorProduto;

Produto produto1 = new Produto(1);
Produto produto2 = new Produto("Computador");
Produto produto3 = new Produto(1500);
Produto produto4 = new Produto(123, "Garrafa", 25);
produto1.MostrarAtributos();
produto2.MostrarAtributos();
produto3.MostrarAtributos();
produto4.MostrarAtributos();
Console.WriteLine($"Quantidade de Instâncias: {Produto.Contador}");