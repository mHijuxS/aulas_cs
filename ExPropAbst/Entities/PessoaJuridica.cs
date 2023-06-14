using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPropAbst.Entities
{
    internal class PessoaJuridica:Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(int numeroFuncionarios, string nome, double renda):base(nome,renda)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if(NumeroFuncionarios > 10)
            {
                return .14 * RendaAnual;
            }
            else
            {
                return .16 * RendaAnual;
            }
        }
    }
}
