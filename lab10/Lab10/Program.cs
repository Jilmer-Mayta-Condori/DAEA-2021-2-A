using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            NortwindDataContext context = new NortwindDataContext();

            //**********************************************************************************
            // Laboratorio punto g
            //var query = from p in context.Products
            //            select p;

            //foreach (var  prod in query )
            //{
            //    Console.WriteLine("ID={0} \t Names={1}" , prod.ProductID, prod.ProductName);
            //}

            //**********************************************************************************
            // Laboratorio punto h
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Names={1}", prod.ProductID, prod.ProductName);
            //}

            //**********************************************************************************
            // Laboratorio punto i
            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Prices={1} \t Names={2}",
            //        prod.ProductID, prod.UnitPrice, prod.ProductName);
            //}

            //**********************************************************************************
            // Laboratorio punto j I. Listar ID, nombre productos cuyo nombre incluye la palabra “Queso”
            //var query = from p in context.Products
            //            where p.ProductName.Contains("Queso")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Prices={1} \t Names={2}",
            //        prod.ProductID, prod.ProductName);
            //}

            //**********************************************************************************
            // Laboratorio punto j II. Listar ID, nombre, presentación (QuantityPerUnit)
            //                         productos cuya presentación sea paquetes (pkg o pkgs)
            //var query = from p in context.Products
            //            where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Names={1} \t Presentacion={2}",
            //        prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            //}

            //**********************************************************************************
            // Laboratorio punto j III. Listar nombre, precio de productos que empiezan con la letra A
            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("Names={0} \t Prices={1}",
            //        prod.ProductName, prod.UnitPrice);
            //}

            //**********************************************************************************
            // Laboratorio punto j IV. Listar ID, nombre de productos sin stock
            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Names={1}",
            //        prod.ProductID, prod.ProductName);
            //}

            //**********************************************************************************
            // Laboratorio punto j V. Listar ID, nombre de productos descontinuados
            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Names={1}",
            //        prod.ProductID, prod.ProductName );
            //}


            //**********************************************************************************
            // Laboratorio punto k
            //Products p = new Products();
            //p.ProductName = "Peruvian Coffe";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "100 pkgs";
            //p.UnitPrice = 50;

            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();


            //**********************************************************************************
            // Laboratorio punto m
            //Categories c = new Categories();
            //c.CategoryName = "Bebidas";
            //c.Description = "Gaseosas, Aguas Minerales, Rehidratantes";

            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();


            //**********************************************************************************
            // Laboratorio punto n
            //Console.WriteLine("*****************************************************");
            //Console.WriteLine("Producto Antes de Editar");
            //var query = from p in context.Products
            //            where p.ProductName == "Tofu"
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Names={1} \t UnitPrice={2} \t UnitsInStock={3} \t Discontinued={4}",
            //        prod.ProductID, prod.ProductName, prod.UnitPrice, prod.UnitsInStock, prod.Discontinued);
            //}

            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //               select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 547;
            //product.Discontinued = true;

            //context.SubmitChanges();

            //Console.WriteLine("*****************************************************");
            //Console.WriteLine("Producto Despues de Editar");

            //var query2 = from p2 in context.Products
            //            where p2.ProductName == "Tofu"
            //            select p2;

            //foreach (var prod2 in query2)
            //{
            //    Console.WriteLine("ID={0} \t Names={1} \t UnitPrice={2} \t UnitsInStock={3} \t Discontinued={4}",
            //        prod2.ProductID, prod2.ProductName, prod2.UnitPrice, prod2.UnitsInStock, prod2.Discontinued);
            //}


            //**********************************************************************************
            // Laboratorio punto o
            //var product = (from p in context.Products
            //               where p.ProductID == 78
            //               select p).FirstOrDefault();

            //context.Products.DeleteOnSubmit(product);
            //context.SubmitChanges();



            Console.ReadKey();
        }
    }
}
