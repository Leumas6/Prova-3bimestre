using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3bimestre
{
    internal class Administrador : Funcionario
    {
        public Administrador()
        {

        }
        public Administrador(string nome, string cpf, string sexo, string matricula, DateTime datanascimento, double salario) : base(nome, cpf, sexo, matricula, datanascimento, salario)
        {
           


        }

        public double Acrescimo()
        {
            
            return 0;
        }
    }
}
