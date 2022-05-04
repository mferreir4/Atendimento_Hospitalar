using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Program
    {float
        static Atendimento void Main(string[] args)
        {
         int[] vetor = new int[5];         
         Console.WriteLine("Controle de entrada de pacientes");
         Paciente[] Lista = new Paciente[10];                 
      
            for (int i=0; i< 10; i++)
            {
                Lista[i] = new Paciente();
                Console.WriteLine("Digite o nome do Paciente");
                Lista [i].nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do paciente");
                Lista[i].idade = Console.ReadLine();
                Console.WriteLine("Digite o CPF do paciente");
                Lista[i].cpf = Console.ReadLine();
                Console.WriteLine("O paciente é preferencial? s/n?");
                if ("s" != "n")
                {
                    Lista[i].preferencia = Console.ReadLine();
                }
                Console.ReadKey();
            }
           
            
        }
         
    }
}
