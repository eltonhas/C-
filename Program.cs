using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioEmpregados {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos empregados deseja cadastrar? ");
            int qtd = int.Parse(Console.ReadLine());

            List<object> listaEmpregados = new List<object>();

            for (int i = 1; i <= qtd; i++) {
                Console.WriteLine($"Empregado #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaEmpregados.Add(new Empregados(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("------------------------"); 
            Console.WriteLine();

            Console.Write("Digite o ID do funcionário para atualizar o salário: ");
            int idEmp = int.Parse(Console.ReadLine());

            Empregados emp = listaEmpregados.Find(x => x.Id == idEmp);

            if (emp != null) {
                Console.Write("Digite a porcentagem do aumento: ");
                double porc = double.Parse(Console.ReadLine());

                emp.aumentarSalario(porc);
            } else {
                Console.WriteLine("Esse Id não existe!");
            }



            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Lista de empregados: ");
            foreach( object obj in listaEmpregados) {
                Console.WriteLine(obj);
            }

        }
    }
}
