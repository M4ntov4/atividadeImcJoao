using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academiaRegistro
{
    class Pessoa
    {
        string nome;
        int idade;
        double peso;
        double altura;
        double imc;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Imc { get => imc; set => imc = value; }


        public Pessoa(string nome, int age, double weight, double height)
        {
            this.Nome = nome; //this.Nome refere ao encapsulamento, já o nome do atributo apos o igual é o que o usuario ira atribuir no Program.CS
            this.Idade = age;
            this.Peso = weight;
            this.Altura = height;
           
            
        }

          //static posso chamar um metodo de onde quiser, sem precisar criar uma instancia "objeto"   

        // para calcular imc

        public static double CalcularImc(double peso, double altura)
        {
           
            return  peso / (altura * altura);
             
        }


        // informar a tabela
        public static string DefinirIMC(double imc)
        {
            string status;

            if (imc >= 40)
            {
                 status = "Obesidade Grau 3";
            }
            else
            {
                if (imc >= 35 && imc < 40)
                {
                     status = "Obesidade Grau 2";
                }
                else
                {
                    if (imc >= 30 && imc < 35)
                    {
                        status = "Obesidade Grau 1";
                    }
                    else
                    {
                        if (imc >=25 && imc < 30)
                        {
                            status = "SobrePeso";
                        }
                        else
                        {
                            if (imc >= 18.5 && imc < 25)
                            {
                                status = "Peso Normal";
                            }
                            else
                            {
                                status = "Abaixo do Peso";
                            }
                        }
                    }
                }
            }

            return status;

        }




        ~Pessoa() { }
    }
}
