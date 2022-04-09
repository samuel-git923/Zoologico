using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooZoologico
{
    public class AnimalPlus : Animal
    {
        public AnimalPlus() : base()
        {
            this.TipoAlimentacao = "";
        }

        public AnimalPlus(String especie, Double peso, String tipoAlimentacao) : base(especie, peso)
        {
            this.TipoAlimentacao = tipoAlimentacao;
        }
      
        public String TipoAlimentacao { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("Especie: " + this.Especie);
            Console.WriteLine("Peso: " + this.Peso);
            Console.WriteLine("Tipo de ALimentação: " + this.TipoAlimentacao);
        }
    }
}
