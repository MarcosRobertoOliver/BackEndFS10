using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BackEndProj.Interfaces; //import


namespace BackEndProj.Classes
{
    public class Pessoa : IPessoa
    {
       public string nome { get; set; }
       public Endereco endereco { get; set; }
       public float rendimento { get; set; }

        public float PagarImposto(float parRendimento)
        {
            throw new NotImplementedException();
        }
        //metodo
    }
}