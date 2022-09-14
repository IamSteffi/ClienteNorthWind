using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClienteNorthWind
{
    internal class Program
    {

        static NorthWindReferences1.WSNorthwindSoapClient service = new NorthWindReferences1.WSNorthwindSoapClient();

        static string[] Productos = { "ProductID", "ProductName", "SupplierID", "CategoryID", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued" };
        static string[] Shippers = { "ShipperID", "CompanyName", "Phone" };
        static string[] Suppliers = { "SupplierID", "CompanyName", "ContactName", "ContactTitle", "Address", "City","Region", "PostalCode", "Country", "Phone" ,"Fax","HomePage"};
        public static void ListarT(int Tabla)
        {
            DataSet ds = new DataSet();
            Console.WriteLine("==============================================");
            switch (Tabla)
            {
                case 1:
                    ds = service.ListarProducts();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Productos.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                case 2:
                    ds = service.ListarShippers();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Shippers.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                case 3:
                    ds = service.ListarSuppliers();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Suppliers.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                default:
                    break;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("Cliente Consola NorthWind");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            bool flag = true;
            bool flagi = false;

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido al mantenimiento de las tablas: ");
                Console.WriteLine("Products[1]");
                Console.WriteLine("Shippers[2]");
                Console.WriteLine("Suppliers[3]");
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");

                string tabla = Console.ReadLine();
                string opcs = "Listar[1]\nAgregar[2]\nActualizar[3]\nEliminar[4]";

                switch(tabla)
                {
                    case "1":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Products");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Products: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Productos.Length - 1];
                            string productid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(1);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 1; i < Productos.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Productos[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.AgregarProducts(nuevafilap[0], nuevafilap[1], nuevafilap[2], nuevafilap[3], nuevafilap[4], nuevafilap[5], nuevafilap[6], nuevafilap[7], nuevafilap[8]);
                                    ListarT(1);
                                    break;
                                case 3:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ACTUALIZAR===================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese ProductID: ");
                                    productid = Console.ReadLine();

                                    for (int i = 1; i < Productos.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Productos[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.ActualizarProducts(productid, nuevafilap[0], nuevafilap[1], nuevafilap[2], nuevafilap[3], nuevafilap[4], nuevafilap[5], nuevafilap[6], nuevafilap[7], nuevafilap[8]);
                                    ListarT(1);
                                    break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese ProductID: ");
                                    productid = Console.ReadLine();
                                    service.EliminarProducts(productid);
                                    ListarT(1);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }

                        break;
                    case "2":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Shippers");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Shippers: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Shippers.Length - 1];
                            string Shippersid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(2);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 1; i < Shippers.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Shippers[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.AgregarShippers(nuevafilap[0], nuevafilap[1]);
                                    ListarT(2);
                                    break;
                                case 3:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ACTUALIZAR===================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese ShippersID: ");
                                    Shippersid = Console.ReadLine();

                                    for (int i = 1; i < Shippers.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Shippers[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.ActualizarShippers(Shippersid, nuevafilap[0], nuevafilap[1]);
                                    ListarT(2);
                                    break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese ShippersidID: ");
                                    Shippersid = Console.ReadLine();
                                    service.EliminarProducts(Shippersid);
                                    ListarT(2);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }
                            break;
                    case "3":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Suppliers");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Suppliers: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Suppliers.Length - 1];
                            string Suppliersid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(3);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 1; i < Suppliers.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Suppliers[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.AgregarSuppliers(nuevafilap[0], nuevafilap[1], nuevafilap[2], nuevafilap[3], nuevafilap[4], nuevafilap[5], nuevafilap[6], nuevafilap[7], nuevafilap[8], nuevafilap[9], nuevafilap[10]);
                                    ListarT(3);
                                    break;
                                case 3:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ACTUALIZAR===================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese SuppliersID: ");
                                    Suppliersid = Console.ReadLine();

                                    for (int i = 1; i < Suppliers.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Suppliers[i] + ": ");
                                        nuevafilap[i - 1] = Console.ReadLine();
                                    }
                                    service.ActualizarSuppliers(Suppliersid, nuevafilap[0], nuevafilap[1], nuevafilap[2], nuevafilap[3], nuevafilap[4], nuevafilap[5], nuevafilap[6], nuevafilap[7], nuevafilap[8], nuevafilap[9], nuevafilap[10]);
                                    ListarT(3);
                                    break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese SuppliersID: ");
                                    Suppliersid = Console.ReadLine();
                                    service.EliminarSuppliers(Suppliersid);
                                    ListarT(3);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("==============================================");



                Console.WriteLine("==============================================");



                Console.WriteLine();

                //Prodcuts
                //Shippers
                //Suppliers


            }
            Console.ReadKey();
        }
        
    }
}
