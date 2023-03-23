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


            Pessoa bruno = new Pessoa("Bruno", 45, 80, 1.8);

            double imc = Pessoa.CalcularImc(bruno.Peso, bruno.Altura);

            Console.WriteLine(Pessoa.DefinirIMC(imc));

            Console.ReadKey();
        }
    }
}
