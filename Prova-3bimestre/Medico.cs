using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3bimestre
{
    internal class Medico : Funcionario
    {

        public string Crm {get ; set ;}

        public double ValorHoraExtra { get; set ;}

        public string Especialidade { get; set ;}

        public Medico(string crm, double valorHoraExtra, string especialidade, string nome, string cpf, string sexo,string matricula, DateTime datanascimento, double salario ) : base(nome, cpf, sexo, matricula, datanascimento, salario)
        {
            
            Crm = crm;
            ValorHoraExtra = valorHoraExtra;
            Especialidade = especialidade;
        }

        public Medico()
        {
        }
    }
}
