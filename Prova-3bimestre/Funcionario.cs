using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3bimestre
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Sexo { get; set;}
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome,  string cpf, string sexo, string matricula, DateTime dataNascimento, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Salario = salario;
        }

       
    }
}
