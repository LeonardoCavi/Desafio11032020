using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio11032020
{
    class IMCModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float IMC { get; set; }

        public IMCModel(string nome, int idade, float peso, float altura, float imc)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            IMC = imc;
        }
        
    }
}
