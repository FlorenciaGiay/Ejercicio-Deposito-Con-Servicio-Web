using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Practica_Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DepositoDeComputacion.Instance.ProductoAgregado_Eliminado += Deposito_ProductoAgregado_Eliminado;
            DepositoDeComputacion.Instance.ProductoAgregado_Eliminado += Deposito_DescripcionProductos;
            string modelo = Console.ReadLine();
            string marca = Console.ReadLine();
            int numeroserie = int.Parse(Console.ReadLine());
            string productoaagregar = Console.ReadLine();
            if (productoaagregar == "Monitor")
            {
                short anofabricacion = short.Parse(Console.ReadLine());
                Nullable<int> pulgadas = int.Parse(Console.ReadLine());
                DepositoDeComputacion.Instance.AgregarProducto(modelo, marca, numeroserie, anofabricacion, pulgadas);
                DepositoDeComputacion.Instance.AgregarProducto(modelo, marca, numeroserie, anofabricacion, 18);
                DepositoDeComputacion.Instance.AgregarProducto(modelo, marca, numeroserie, anofabricacion, 20);
            }
            else
            {
                string procesador = Console.ReadLine();
                string valormemoria = Console.ReadLine();
                if (valormemoria.ValidarMemoria())
                {
                    MemoriaRAM memoria = (MemoriaRAM)Enum.Parse(typeof(MemoriaRAM), valormemoria);
                    string fabricante = Console.ReadLine();
                    DepositoDeComputacion.Instance.AgregarProducto(modelo, marca, numeroserie, procesador, memoria, fabricante);
                }
                else
                {
                    throw new Exception("Valor de memoria fuera del rango.");
                }
            }
            Console.ReadKey();
        }

        private static void Deposito_ProductoAgregado_Eliminado(object sender, InfoProductoArgs e)
        {
            Console.WriteLine($"{e.Tipo} - {e.Producto.Identificador} - Producto {e.Operacion}");
        }

        private static void Deposito_DescripcionProductos(object sender, InfoProductoArgs e)
        {

            foreach (ElementoDeComputacion producto in DepositoDeComputacion.Instance.ObtenerListaUnicaProductos())
            {
                if (DepositoDeComputacion.Instance.ObtenerListaUnicaProductos().Last() == producto)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(DepositoDeComputacion.Instance.ObtenerDescripcionProducto(producto));
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
