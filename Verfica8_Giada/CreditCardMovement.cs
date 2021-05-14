using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verfica8_Giada
{

    class CreditCardMovement : IMovement
    {
        public string NomeOperazione { get; set; }
        public decimal Importo { get; set; }
        public DateTime DataOperazione { get; set; }
        public Circuito TipoCircuito { get; set; }
        public string NumeroCarta { get; set; }

        public CreditCardMovement(decimal importo, DateTime data, Circuito circuito, string numeroCarta)
        {
            Importo = importo;
            DataOperazione = data;
            TipoCircuito = circuito;
            NumeroCarta = numeroCarta;
        }
        public override string ToString()
        {
            return $"Data: {this.DataOperazione}\n" +
                $"{this.NomeOperazione} di {this.Importo}\n" +
                $"Numero carta: {this.NumeroCarta}\n" +
                $"Circuto: {TipoCircuito}";
        }


    }
}
