using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndProj.Interfaces;

namespace BackEndProj.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica 
    {
        public string cpf { get; set; }
        public string dataNascimento { get; set; }


        //Para rendimentos até R$1.500,00 - isento (desconto 0) 
        //Para rendimentos entre R$1.501,00 e R$5.000,00 - desconto de 3% 
        //Para rendimentos acima de R$5.000,01 - desconto de 5%
        public override float PagarImposto(float parRendimento)
        {
            if(parRendimento <= 1500)
            { 
                return parRendimento; //não tem desconto
            }
            else if (parRendimento >= 1501 && parRendimento <= 5000)
            {
                return parRendimento - (parRendimento / 100) * 3; // desconto de 3% do rendimento
            } else {
                return parRendimento - (parRendimento / 100) * 5; // desconto de 5% do rendimento
            }
            
        }

        public bool ValidarDataNascimento(string parDtNasc)
        {
           DateTime dataConvertida;

           if(DateTime.TryParse(parDtNasc, out dataConvertida)){
            // Console.WriteLine($"Data Convertida:{dataConvertida}");

            DateTime dataAtual = DateTime.Today;
            // Console.WriteLine($"Data Atual:{dataAtual}");

            double anos = (dataAtual - dataConvertida).TotalDays / 365;
            // Console.WriteLine($"Anos Convertido:{anos}");

            if (anos >= 18)
            {
                return true;
            }

            } 
                return false;
        }
    }
}