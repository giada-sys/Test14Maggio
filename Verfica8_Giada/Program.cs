using System;
using System.Collections.Generic;

namespace Verfica8_Giada
{
    public enum Circuito
    {
        AMEX,
        VISA,
        MASTERCARD,
        OTHER
    }
    class Program
    {
        enum Movimento
        {
            CashMovement,
            TransfertMovement,
            CreditCardMovement
        }

        static void Main(string[] args)
        {

            Account c = new Account(1785, "CariGe");

            #region InputUtente
            Console.WriteLine("-------- Banca Carige--------");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Che tipo di operazione vuoi effettuare?");
                Console.WriteLine("- Versamento(1)");
                Console.WriteLine("- Prelievo (2)");
                Console.WriteLine("- Bonifico con conto Bancario (3)");
                Console.WriteLine("- Bonifico con Carta di Credito (4)");
                Console.WriteLine("- Prospetto conto (5)");
                

                int.TryParse(Console.ReadLine(), out int mov);

               
                if (mov == 1)
                {
                    Console.WriteLine("Inserire l'importo: ");
                    decimal.TryParse(Console.ReadLine(), out decimal importo);
                    IMovement cashMovement = new CashMovement(importo, DateTime.Now, "Gregorio");
                    Console.WriteLine(c + cashMovement);

                }
                else if (mov == 2)
                {
                    Console.WriteLine("Inserire l'importo: ");
                    decimal.TryParse(Console.ReadLine(), out decimal importo);
                    IMovement cashMovement = new CashMovement(importo, DateTime.Now, "Gregorio");
                    Console.WriteLine(c - cashMovement);
                }
                else if (mov == 3)
                {
                    Console.WriteLine("Inserire l'importo: ");
                    decimal.TryParse(Console.ReadLine(), out decimal importo);

                    Console.WriteLine("Inserire la Banca di destinazione: ");
                    
                    IMovement transferMovement = new TransfertMovement(importo, DateTime.Now, Console.ReadLine(), "Banca Unicredit");
                    Console.WriteLine(c - transferMovement);
                }
                else if (mov == 4)
                {
                    Console.WriteLine("Inserire l'importo: ");
                    decimal.TryParse(Console.ReadLine(), out decimal importo);

                    Console.WriteLine("Inserire il numero della carta:");

                    IMovement creditCardMovement = new CreditCardMovement(importo, DateTime.Now, Circuito.MASTERCARD, Console.ReadLine());
                    Console.WriteLine(c - creditCardMovement);

                }else if (mov == 5)
                {
                    c.Statement();
                }

                Console.WriteLine();
                Console.WriteLine("Vuoi effettuare un'altra operazione? (y/n)");
            } while (Console.ReadKey().Key == ConsoleKey.Y);

            #endregion


        }

    }
}
