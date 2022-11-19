using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BackEndProj.Interfaces; //import


namespace BackEndProj.Classes
{
    public abstract class Pessoa : IPessoa //colocando como abstract não pode mais Estanciar (new)
    {
       public string nome { get; set; }
       public Endereco endereco { get; set; }
       public float rendimento { get; set; }

        public abstract float PagarImposto(float parRendimento);
        
        //metodo
    }
}