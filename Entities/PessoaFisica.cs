﻿namespace Calculo_de_Imposto.Entities
{
    class PessoaFisica : Contribuinte
    {

        public double GastosSaude { get; set; }


        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Taxa()
        {
            if (RendaAnual < 20000)
            {
                return (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }

            else
            {
                return (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }
                  
        }
    }
}
