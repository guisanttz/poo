using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidFuncionario
{
    public interface ICalculadoraSalarios
    {
        double calcularSalario(Funcionario funcionario);
    }
}