using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Calculo
    {
        public decimal ObtenhaMontante(decimal capitalInicial, decimal taxaJuro, decimal prazo)
        {
            //Código a ser implementado
            decimal FV =0;


            for (int aux = 0; aux <= prazo; aux++)
            {
                FV = capitalInicial * (1 + taxaJuro) * aux;

            }

            //FV = capitalInicial * ( taxaJuro prazo));


            Console.WriteLine("Montante com juros aplicado : " + FV);
            Console.ReadKey();
            return FV;

        }
    }
}
