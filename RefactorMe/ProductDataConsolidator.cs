using RefactorMe.DontRefactor.Data.Implementation;
using RefactorMe.DontRefactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RefactorMe
{
    public static class ProductDataConsolidator
    {
        public static List<Product> Get(string currencyType)
        {
            try
            {
                var lawnMowerDB = new LawnmowerRepository().GetAll();
                var phoneCaseDB = new PhoneCaseRepository().GetAll();
                var tShirtDB = new TShirtRepository().GetAll();

                List<IQueryable> productsFromDBList = new List<IQueryable>
                {
                    lawnMowerDB,
                    phoneCaseDB,
                    tShirtDB
                };
                List<dynamic> allProductDetails = GetProductDetailsForAllProductLists(productsFromDBList);

                if (allProductDetails != null)
                {
                    return CombineAllProductDetailsLists(allProductDetails, currencyType);

                }
                else
                {
                    throw new ArgumentNullException(nameof(allProductDetails));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        private static List<dynamic> GetProductDetailsForAllProductLists(List<IQueryable> productListsFromDB)
        {
            List<dynamic> allProductsDetailsList = new List<dynamic>();

            try
            {
                foreach (var productType in productListsFromDB) 
                {
                    foreach (var productDetails in productType) 
                    {
                        allProductsDetailsList.Add(productDetails);

                    }
                }
                return allProductsDetailsList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        private static List<Product> CombineAllProductDetailsLists(List<dynamic> allProductsDetailsList, string currencyType)
        {
            List<Product> combinedProductsList = new List<Product>();

            try
            {
                for (int i = 0; i < allProductsDetailsList.Count; i++)
                {
                    string prodType = allProductsDetailsList[i].ToString()
                        .Substring(allProductsDetailsList[i].ToString()
                        .LastIndexOf(".") + 1);


                    combinedProductsList.Add(new Product()
                    {
                        Id = allProductsDetailsList[i].Id,
                        Name = allProductsDetailsList[i].Name,
                        Price = currencyType != CurrencyTypes.values[0] ? (currencyType == CurrencyTypes.values[1] ? allProductsDetailsList[i].Price * 0.76 : allProductsDetailsList[i].Price * 0.67) : allProductsDetailsList[i].Price,  //if USD * 0.76 / euros = * 0.67
                        Type = prodType,
                    });
                }
                return combinedProductsList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }
}
