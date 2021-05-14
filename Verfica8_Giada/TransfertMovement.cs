using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verfica8_Giada
{
    class TransfertMovement : IMovement
    {
        public string NomeOperazione { get; set; }
        public decimal Importo { get; set; }
        public DateTime DataOperazione { get; set; }
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        public TransfertMovement(decimal importo, DateTime data, string origine, string destinazione)
        {
            Importo = importo;
            DataOperazione = data;
            BancaOrigine = origine;
            BancaDestinazione = destinazione;
        }
        public override string ToString()
        {
            return $"{this.DataOperazione}\n" +
                $"{this.NomeOperazione} di {this.Importo}\n" +
                $"Banca Origine: {this.BancaOrigine}\n" +
                $"Banca Destinazione: {this.BancaDestinazione}";
        }


    }
}
