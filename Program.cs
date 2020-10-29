﻿using System;
using System.Globalization;
using System.Collections.Generic;

namespace POO_TarefaSalarioEncapsulamento
//Programa para ler um número inteiro N e depois os dados (id,nome,esalario)de N funcionários. Não deve haver repetição de id.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de informações
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Criação da lista Empregados
            List<Empregados> list = new List<Empregados>();

            //Criação do laço para inserção de dados conforme N
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");   //Informa o número sequencial do funcionário
                Console.Write("Id: ");                          //Solicita um número de identificação "ID"
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");                        //Solicita o nome do funcionário
                string nome = Console.ReadLine();
                Console.Write("Salário: ");                     //Solicita o valor do salario inicial do funcionário
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                //Adição das informações na lista
                list.Add(new Empregados(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("ID do funcionário que receberá o aumento: ");    //Solicita o ID. 
            int searchId = int.Parse(Console.ReadLine());                   //A variável searchId receberá o valor da ID informada.

            //A variável emp receberá um valor da lista, caso seja encontrado o ID informado.
            Empregados emp = list.Find(x => x.Id == searchId);
            if (emp != null)    //Se a variável emp não for nula...
            {
                Console.Write("Porcentagem de aumento do salário: ");   //Solicita o valor percentual a ser adicionado.
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(porcentagem);
            }
            else  //Se o ID não existir...
            {
                Console.WriteLine("Este funcionário não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionários da Bravo:");

            //Laço que cria uma lista de funcionários e seus salários.
            foreach (Empregados obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}