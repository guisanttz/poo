using EncapsulamentoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        int aumento;
        Funcionario f1 = new Funcionario();
        Console.WriteLine("Digite a matrícula: ");
        f1.Matricula = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome: ");
        f1.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salário: ");
        f1.Salario = Convert.ToDouble(Console.ReadLine());
        f1.MostrarAtributos();
        Console.WriteLine("Digite a porcentagem de aumento: ");
        aumento = Convert.ToInt32(Console.ReadLine());
        f1.CalcularAumento(aumento);
        f1.MostrarAtributos();
    }
}