using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidFuncionario
{
    public class FuncionarioPermanente : Funcionario
    {
        public override double CalcularSalario()
        {
            return Salario * 1.3;
        }
    }
}