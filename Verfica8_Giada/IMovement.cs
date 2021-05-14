using System;

namespace Verfica8_Giada
{
    public interface IMovement
    {
        decimal Importo { get; set; }
        DateTime DataOperazione { get; set; }
        public string NomeOperazione { get; set; }
    }
}