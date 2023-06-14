using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPropAbst.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(double gastosSaude, string nome, double rendaAnual):base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000)
            {
                return .15 * RendaAnual;
            }
            else
            {
                if (GastosSaude != 0)
                {
                    return .25 * RendaAnual - .5*GastosSaude;
                }
                else
                {
                    return .25 * RendaAnual;
                }
            }
        }
    }
}
