using System;
using System.Collections.Generic;
using System.Globalization;

namespace Modificador
{
    class Program
    {
        static void Main(string[] args)
        {

          
           /* Console.WriteLine("Insira os valores que o vetor irá possuir:");
            int n1 = int.Parse(Console.ReadLine());
            string[] vet = new string[n1];
            for(int i = 0; i < n1; i++){
                System.Console.WriteLine("Insira o " + (i+1) + "° valor do vetor:");
                vet[i] = Console.ReadLine();
            }

            for(int i = 0; i < n1; i++){
                System.Console.WriteLine(vet[i] + "\n");
            }
        
            List<string> lista = new List<string>();

            for(int i = 0; i < 2; i++){
                System.Console.WriteLine("Insira o " + (i+1) + "° valor da lista:");
                lista.Add(Console.ReadLine()); 
            }

            System.Console.WriteLine("\nInformações da lista:");
           foreach(string List in lista){
               System.Console.WriteLine (List);            
           }


           List<int> lista1 = new List<int>();
           for(int i = 0; i < 5; i++){
               System.Console.WriteLine("Insira o " + (i+1) + "° valor da lista:");
               lista1.Add(int.Parse(Console.ReadLine()));
           }


            System.Console.WriteLine("\nSoma dos quarto e quinto valor:");
            System.Console.WriteLine(lista1[3] + lista1[4]);

            int count = 0;

            for(int i = 0; i < 5; i++){
                count = lista1[i] + count;
            }

            System.Console.WriteLine("\nA soma de todos os valores da lista é: \n" + count);


            foreach(int List in lista1){
              
           }*/

          /* System.Console.WriteLine("Insira um valor:\n");
           int x = int.Parse(Console.ReadLine());
           System.Console.WriteLine("Insira outro valor:\n");
           int y = int.Parse(Console.ReadLine());*/



           
           /*System.Console.WriteLine("Insira a quantidade de valores que o vetor irá armazenar:");
           int n1 = int.Parse(Console.ReadLine());
           double [] vet = new double[n1];
            for(int i = 0; i < n1; i++){
                System.Console.WriteLine("Insira o " + (i+1) + "° valor do vetor:");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double count = 0;
            for(int i = 0; i < n1; i++){
                count = vet[i] + count;
            }
           double media = count / n1;

           System.Console.WriteLine("AVERAGE HEIGHT: " + media.ToString("F2", CultureInfo.InvariantCulture));*/



          /* System.Console.WriteLine("Insira a quantidade de produtos que o vetor irá armazenar:");
           int n1 = int.Parse(Console.ReadLine());
           Produto [] vetor = new Produto [n1];
           for(int i = 0; i < n1; i++){
               System.Console.WriteLine("Insira o nome do " + (i+1) + "° produto e seu preço");
               string nome = Console.ReadLine();
               double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               vetor[i] = new Produto();
               vetor[i].preco = preco;
               vetor[i].nome = nome;
           }

           for(int i = 0; i < n1; i++){
               System.Console.WriteLine(vetor[i].nome + "\n" + vetor[i].preco + "\n");
           }
           double count = 0;

           for(int i = 0; i < n1; i++){
               count = vetor[i].preco + count;
           }

           double media = count/n1;

           System.Console.WriteLine("Media do preço dos produtos é " + media.ToString("F2", CultureInfo.InvariantCulture));*/


           System.Console.WriteLine("Quantos quartos serão alugados?:");
           int n1 = int.Parse(Console.ReadLine());
           Estudante [] vet = new Estudante[n1];

           for(int i = 0; i < n1; i++){
               System.Console.WriteLine("Insira o nome do " + (i+1) + "° aluno que irá alugar o quarto:");
               string nome = Console.ReadLine();
               System.Console.WriteLine("Insira o email do " + (i+1) + "° aluno que irá alugar o quarto:");
               string email = Console.ReadLine();
               System.Console.WriteLine("Qual quarto será alugado?");
               char quarto = char.Parse(Console.ReadLine());
               
               vet[i].nome = nome;
               vet[i].email = email;
               vet[i].quarto = quarto; 
           }

           System.Console.WriteLine("Quartos ocupados:\n");
           for(int i = 0; i < n1; i++){
               if(vet[i] != null){
                   System.Console.WriteLine(i + ": " + vet[i]);
               }
           }













          
        }
    }
}

   /* struct Soma{
        public int n1, n2;

        public double soma(){
            return n1+n2;
        }
    }*/
