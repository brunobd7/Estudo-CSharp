using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Ex5
    {
      

        static void Main(string[] args)
        {
            decimal capitalInicial = 10000; //PV
            decimal taxaJuro = 3 / 100 * 10000; //i- TAXA DE JUROS
            decimal prazo = 3; //n - PERIODOS DE CAPTALIZAÇÃO
            //decimal FV = 0; //MONTANTE

            Calculo calc = new Calculo();

            calc.ObtenhaMontante(capitalInicial, taxaJuro, prazo);

        }
        

        //public decimal ObtenhaMontante(decimal capitalInicial, decimal taxaJuro, decimal prazo)
        //{
        //    //Código a ser implementado
            

            
        //    for (int aux = 0; aux <= prazo;aux++)
        //    {
        //        FV = capitalInicial*(1 + taxaJuro)*aux;
                
        //    }

        //    //FV = capitalInicial * ( taxaJuro prazo));


        //    Console.WriteLine("Montante com juros aplicado : "+FV);
        //    Console.ReadKey();
        //    return FV;

        //}
    }
}
