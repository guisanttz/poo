using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidFuncionario
{
    public class FuncionarioContrato : Funcionario
    {
        public override double CalcularSalario()
        {
            return Salario;
        }        
    }
}