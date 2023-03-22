using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academiaRegistro
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            double peso;
            double altura;

            Console.Write("Cadastre seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Cadastre sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("insira peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("insira a altura (ex: 1,80cm): ");
            altura = double.Parse(Console.ReadLine());



            


            Pessoa cliente = new Pessoa(nome,idade,peso,altura); // recebe os parametros (caracteristicas do objeto)

            cliente.CalcularImc(); // faz o calculo de imc
            cliente.DefinirIMC(); // atribui um status

            
            
            Console.WriteLine("Seu nome é: " + cliente.LerNome());
            Console.WriteLine("Sua idade é: " + cliente.LerIdade()+ " anos");
            Console.WriteLine("Seu peso é: " + cliente.LerPeso()+ " Kg");
            Console.WriteLine("Sua Altura é: " + cliente.LerAltura() + "M");
            Console.WriteLine("Seu IMC é: " + cliente.LerImc());
            Console.WriteLine("Seu status de IMC é: " + cliente.LerStatus());

            Console.ReadKey();
        }
    }
}
