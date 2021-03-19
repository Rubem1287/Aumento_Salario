using System;
using System.Collections.Generic;
using System.Globalization;
namespace Aumento_Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> lista = new List<Funcionario>();
            Console.Write("Quantos funcionários deseja registrar? ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int p = 0; p < n; p++)
            {
                count++;
                Console.WriteLine("Funcionário #" + count);
                Console.Write("Id : ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome : ");
                string nome = Console.ReadLine();

                Console.Write("Salário : ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                lista.Add(new Funcionario(id, nome, salario));
            }


            Console.Write("Entre com o Id do funcionário que irá receber o aumento salarial : ");
            int recebeID = int.Parse(Console.ReadLine());

            Funcionario funcionario = lista.Find(x => x.Id == recebeID);


            if (funcionario != null)
            {
                Console.Write("Entre com a porcentagem : ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.adicionar_Salario(porcentagem);
            }
            else
            {
                Console.WriteLine("Erro!! Esse Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Dados dos Funcionários atualizados : ");
            foreach (Funcionario obj in lista)
            {

                Console.WriteLine(obj);
            }







        }



    }
}
