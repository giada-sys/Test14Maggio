using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verfica8_Giada
{

    public class Account
    {

        #region Proprietà
        public int IdConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; } = 0;
        public DateTime DataUltimaOperazione { get; set; } = DateTime.Now;
        public List<IMovement> ListaMovimenti { get; set; } = new List<IMovement>();
        #endregion
        #region Ctors
        public Account(int id, string nomeBanca)
        {
            IdConto = id;
            NomeBanca = nomeBanca;
        }
        #endregion

        #region Overload degli operatori
        public static string operator +(Account a, IMovement mov)
        {
            if (mov == null)
                return "L'operazione non è andata a buon fine, prego ripetere.";

            mov.NomeOperazione = "Accredito";
            a.Saldo += mov.Importo;
            a.DataUltimaOperazione = DateTime.Now;
            a.ListaMovimenti.Add(mov);

            return "L'operazione è andata a buon fine.";
        }
        public static string operator -(Account a, IMovement mov)
        {

            if (mov == null)
                return "L'operazione non è andata a buon fine, prego ripetere.";

            mov.NomeOperazione = "Addebito";
            a.Saldo -= mov.Importo;
            a.DataUltimaOperazione = DateTime.Now;
            a.ListaMovimenti.Add(mov);

            return "L'operazione è andata a buon fine.";
        }
        #endregion

        #region Metodi
        public void Statement()
        {
            Console.WriteLine($"Conto numero {this.IdConto}");
            Console.WriteLine($"Banca: {this.NomeBanca} " +
                $"\nSaldo: {this.Saldo}" +
                $"\nData ultima operazione: {this.DataUltimaOperazione}");

            Console.WriteLine();
            int i = 1;
            foreach (IMovement mov in ListaMovimenti)
            {
                Console.WriteLine("Operazione n. {0}\n{1}",i++, mov.ToString());
            }
        }
        #endregion
    }
}
