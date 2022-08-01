using System;
using System.Collections.Generic;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe
{
    public class RenderProductData
    {
       
        //Render to frontend
        public static void Render()
        {
            foreach (var currency in CurrencyTypes.values)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("            ");
                Console.WriteLine(currency);
                Console.WriteLine("-----------");
                Console.WriteLine("             ");

                List<Product> returnedProductsList = ProductDataConsolidator.Get(currency);

                returnedProductsList.ForEach(item =>
                {
                    Console.WriteLine(item.Type);
                    Console.WriteLine(item.Name);
                    Console.WriteLine("{0:N2}", item.Price, 3);
                    Console.WriteLine("----");
                }); ;
            }

        }
    }
}

