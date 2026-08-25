using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        // c1.numero = 1; este atributo não pode ser acessado,
        //devido o seu encapsulamento por meio da palavra private

        c1.Numero = 1; // esta linha chama o método set
        c1.Titular = "Gui";
        c1.Saldo = 100;
        Console.WriteLine("Número da conta: " + c1.Numero);
        c1.MostrarAtributos();

        // if (c1.Numero < 10) get
    }
}