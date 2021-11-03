using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                // ejercios a realizar 1,2,3,4,5,8,9,10,12,14,15

                var productos = AWEntities.Product;

                //********************Ejercicio 1**********************************************

                //IQueryable<String> productNames = from p in productos
                //                                  select p.Name;
                //Console.WriteLine("Prodcutos:");
                //foreach(var productName in productNames)
                //{
                //    Console.WriteLine(productName);
                //}

                //********************Ejercicio 2 **********************************************

                //IQueryable<String> productNames = productos.Select(p => p.Name);
                //Console.WriteLine("Prodcutos:");
                //foreach(var productName in productNames)
                //{
                //    Console.WriteLine(productName);
                //}

                //********************Ejercicio 3 **********************************************

                //IQueryable<Product> productsQuery = from p in productos
                //                                  select p;

                //IQueryable<Product> LargeProducts = productsQuery.Where(p => p.Size == "L");

                //Console.WriteLine("Productos de tamaño 'L' : ");
                //foreach (var product in LargeProducts)
                //{
                //    Console.WriteLine(product.Name);
                //}

                //********************Ejercicio 4 **********************************************

                //IQueryable<Product> productsQuery = from product in AWEntities.Product
                //                                    select product;
                //Console.WriteLine("Prooductos");
                //foreach (var prod in productsQuery)
                //{
                //    Console.WriteLine(prod.Name);
                //}


                //********************Ejercicio 5 **********************************************

                //var query = from product in AWEntities.Product
                //            select new
                //            {
                //                ProductID = product.ProductID,
                //                ProductName = product.Name
                //            };

                //Console.WriteLine("Informacion de productos");
                //foreach ( var productInfo in query)
                //{
                //    Console.WriteLine(" ProductsID : {0} Products Name : {1}",
                //        productInfo.ProductID, productInfo.ProductName);
                //}

                //********************Ejercicio 8 **********************************************

                //int orderQtyMin = 2;
                //int orderQtyMax = 6;

                //var query = from order in AWEntities.SalesOrderDetail
                //            where order.OrderQty > orderQtyMin
                //            && order.OrderQty < orderQtyMax
                //            select new
                //            {
                //                SalesOrderID = order.SalesOrderID,
                //                OrderQty = order.OrderQty
                //            };

                //foreach (var order in query)
                //{
                //    Console.WriteLine("Order ID: {0} Order quantity: {1}",
                //        order.SalesOrderID, order.OrderQty);
                //}

                //********************Ejercicio 9 **********************************************

                //String color = "Red";

                //var query = from product in AWEntities.Product
                //            where product.Color == color
                //            select new
                //            {
                //                Name = product.Name,
                //                ProductNumber = product.ProductNumber,
                //                ListPrice = product.ListPrice
                //            };

                //foreach (var product in query)
                //{
                //    Console.WriteLine("Name: {0}", product.Name);
                //    Console.WriteLine("Product number: {0}", product.ProductNumber);
                //    Console.WriteLine("List price: ${0}", product.ListPrice);
                //    Console.WriteLine("");
                //}

                //********************Ejercicio 10 **********************************************

                //int?[] productModelIds = { 19, 26, 118 };
                //var products = from p in AWEntities.Product
                //               where productModelIds.Contains(p.ProductModelID)
                //               select p;

                //foreach ( var product in products)
                //{
                //    Console.WriteLine("{0}: {1}", 
                //        product.ProductModelID, product.ProductID);
                //}

                //********************Ejercicio 12 **********************************************

                //IQueryable<Decimal> sortedPrices = from p in AWEntities.Product
                //                                   orderby p.ListPrice descending
                //                                   select p.ListPrice;

                //Console.WriteLine("Lista de precios desde el mas alto al mas bajo:");
                //foreach (Decimal price in sortedPrices)
                //{
                //    Console.WriteLine(price);
                //}

                //********************Ejercicio 14 **********************************************

                //var products = AWEntities.Product;
                //var query = from product in products
                //            group product by product.Style into g
                //            select new
                //            {
                //                Style = g.Key,
                //                AverageListPrice = g.Average(product => product.ListPrice)
                //            };

                //foreach ( var product in query)
                //{
                //    Console.WriteLine("Estilo: {0} Precio promedio: {1}",
                //        product.Style, product.AverageListPrice);
                //}

                //********************Ejercicio 15 **********************************************

                //var products = AWEntities.Product;
                //var query = from product in products
                //            group product by product.Color into g
                //            select new
                //            {
                //                Color = g.Key,
                //                ProductCount = g.Count()
                //            };

                //foreach (var product in query)
                //{
                //    Console.WriteLine("Color = {0} \t Cantidad = {1}",
                //        product.Color, product.ProductCount);
                //}

                Console.ReadKey();
            }
        }
    }
}
