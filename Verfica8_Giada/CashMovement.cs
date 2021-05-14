using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verfica8_Giada
{
    class CashMovement : IMovement
    {
        public string NomeOperazione { get; set; }
        public decimal Importo { get; set; }
        public DateTime DataOperazione { get; set; }
        public string NomeEsecutore { get; set; }

        public CashMovement(decimal importo, DateTime data, string nome)
        {
            Importo = importo;
            DataOperazione = data;
            NomeEsecutore = nome;
        }
        public override string ToString()
        {
            return $"Data: {this.DataOperazione}\n" +
                $"{this.NomeOperazione} di {this.Importo}\n" +
                $"Nome esecutore: {this.NomeEsecutore}";
        }
    }
}
