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
        string status;
        int idade;
        double peso;
        double altura;
        double imc;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Imc { get => imc; set => imc = value; }
        public string Status { get => status; set => status = value; }

        public Pessoa(string nome, int age, double weight, double height)
        {
            this.Nome = nome; //this.Nome refere ao encapsulamento, já o nome do atributo apos o igual é o que o usuario ira atribuir no Program.CS
            this.Idade = age;
            this.Peso = weight;
            this.Altura = height;
           
            
        }

        // Para Alterar os Atributos

        public void AlterarNome(string nome)
        {
            this.Nome = nome;
        }

        public void Alteraridade(int idade)
        {
            this.Idade = idade;
        }

        public void AlterarPeso(double peso)
        {
            this.Peso = peso;
        }

        public void AlterarAltura(double altura)
        {
            this.Altura = altura;
        }

           // Para consultar os Atributos

        public string LerNome()
        {
            return this.Nome;
        }

        public int LerIdade()
        {
            return this.Idade;
        }

        public double LerPeso()
        {
            return this.Peso;
        }

        public  double LerAltura()
        {
            return this.Altura;
        }

        public double LerImc()
        {
            return this.Imc;
        }

        public string LerStatus()
        {
            return this.Status;
        }

        // para calcular imc

        public void CalcularImc()
        {

            this.Imc = this.peso / (this.altura * this.altura);

        }


        // informar a tabela
        public void DefinirIMC()
        {
            if (this.Imc >= 40)
            {
                this.Status = "Obesidade Grau 3";
            }
            else
            {
                if (this.Imc >= 35 && this.Imc < 40)
                {
                    this.Status = "Obesidade Grau 2";
                }
                else
                {
                    if (this.Imc >= 30 && this.Imc < 35)
                    {
                        this.Status = "Obesidade Grau 1";
                    }
                    else
                    {
                        if (this.Imc >=25 && this.Imc < 30)
                        {
                            this.Status = "SobrePeso";
                        }
                        else
                        {
                            if (this.Imc >= 18.5 && this.Imc < 25)
                            {
                                this.Status = "Peso Normal";
                            }
                            else
                            {
                                this.Status = "Abaixo do Peso";
                            }
                        }
                    }
                }
            }


        }




        ~Pessoa() { }
    }
}
