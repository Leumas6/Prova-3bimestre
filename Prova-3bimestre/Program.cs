using Prova_3bimestre;
using System;
using System.Runtime.Intrinsics.X86;

class Prova
{

    static void Main(string[] args)
    {
        
        List<Medico> listmedico = new List<Medico>();
        List<Administrador> listAdministrador = new List<Administrador>();

           
        while (true) 
        {
            
            Console.WriteLine("Digite 1 para cadastrar um médico");
            Console.WriteLine("Digite 2 para cadastrar um funcionário administrador");
            Console.WriteLine("Digite 3 para ver as Listas");
            int opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Medico F = new Medico();
                Console.WriteLine("Digite as Caracteristicas do funcionário");
                Console.Write("Nome:");


                string nome = Console.ReadLine();
                F.Nome = nome;

                Console.Write("Cpf:");
                string cpf = Console.ReadLine();
                F.Cpf = cpf;

                Console.Write("Sexo:");
                string sexo = Console.ReadLine();
                F.Sexo = sexo;

                Console.Write("Matricula:");
                string matricula = Console.ReadLine();
                F.Matricula = matricula;

                Console.Write("Data de nascimento:");
                DateTime natanascimento = Convert.ToDateTime(Console.ReadLine());
                F.DataNascimento = natanascimento;

                Console.Write("Salario:");
                double salario = Convert.ToDouble(Console.ReadLine());
                F.Salario = salario;

                Console.Write("Crm:");
                string Crm = Console.ReadLine();
                F.Crm = Crm;


                Console.Write("Hora extra:");
                double valorHoraExtra = Convert.ToDouble(Console.ReadLine());
                F.ValorHoraExtra = valorHoraExtra;

                Console.Write("Especialidade:");
                string especialidade = Console.ReadLine();
                F.Especialidade = especialidade;

                salario = salario + (salario * 20 / 100);

                listmedico.Add(F);

                Console.WriteLine("\nDeseja sair ?");
                string resposta2 = Convert.ToString(Console.ReadLine());

                if (resposta2 == "sim")
                {
                    break;
                }
                else if (resposta2 == "não \n")
                {

               
                }
                
            }
            else if (opcao == 2)
            {
                Administrador A = new Administrador();
                Console.WriteLine("Digite as Caracteristicas do funcionário");
                Console.Write("Nome:");


                string nome = Console.ReadLine();
                A.Nome = nome;

                Console.Write("Cpf:");
                string cpf = Console.ReadLine();
                A.Cpf = cpf;

                Console.Write("Sexo:");
                string sexo = Console.ReadLine();
                A.Sexo = sexo;

                Console.Write("Matricula:");
                string matricula = Console.ReadLine();
                A.Matricula = matricula;

                Console.Write("Data de nascimento:");
                DateTime natanascimento = Convert.ToDateTime(Console.ReadLine());
                A.DataNascimento = natanascimento;

                Console.Write("Salario:");
                double salario = Convert.ToDouble(Console.ReadLine());
                A.Salario = salario;

                

                salario = salario + (salario * 15 / 100);

                listAdministrador.Add(A);

                Console.WriteLine("\nDeseja sair ?");
                string resposta2 = Convert.ToString(Console.ReadLine());

                if (resposta2 == "sim")
                {
                    break;
                }
                else if (resposta2 == "não \n")
                {


                }
                else if (opcao == 3)
                {
                    foreach (Medico F in listmedico)
                    {
                      

                    }
                    foreach (Administrador A in listAdministrador)
                    {
                    }
                    
                }
            }
            




        }
        
        }

    }

}
