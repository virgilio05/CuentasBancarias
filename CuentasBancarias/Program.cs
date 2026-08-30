using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasBancarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════╗");
            Console.WriteLine("║     SISTEMA DE GESTIÓN DE CUENTAS BANCARIAS     ║");
            Console.WriteLine("║  Aplicación de Programación Orientada a Objetos ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            // Crear dos objetos de tipo CuentaBancaria
            CuentaBancaria cuenta1 = new CuentaBancaria("Juan Pérez", "100001", 5000.00m);
            CuentaBancaria cuenta2 = new CuentaBancaria("María García", "100002", 3500.50m);

            // ═══════════════════════════════════════════════════════════
            // Mostrar datos iniciales
            // ═══════════════════════════════════════════════════════════
            Console.WriteLine("║ PASO 1: DATOS INICIALES DE LAS CUENTAS");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            cuenta1.MostrarDetalles();
            cuenta2.MostrarDetalles();

            Console.WriteLine("Presione cualquier tecla para continuar...\n");
            Console.ReadKey();
            Console.Clear();

            // ═══════════════════════════════════════════════════════════
            // Realizar un depósito en la primera cuenta
            // ═══════════════════════════════════════════════════════════
            Console.WriteLine("║ PASO 2: REALIZAR OPERACIONES");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            Console.WriteLine("--- Depósito en Cuenta 1 ---");
            Console.WriteLine("Cuenta de: Juan Pérez");
            cuenta1.Depositar(2500.00m);

            Console.WriteLine("Presione cualquier tecla para continuar...\n");
            Console.ReadKey();
            Console.Clear();

            // ═══════════════════════════════════════════════════════════
            // Realizar un retiro en la segunda cuenta
            // ═══════════════════════════════════════════════════════════
            Console.WriteLine("║ PASO 2: REALIZAR OPERACIONES (continuación)");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            Console.WriteLine("--- Retiro en Cuenta 2 ---");
            Console.WriteLine("Cuenta de: María García");
            cuenta2.Retirar(1500.00m);

            Console.WriteLine("Presione cualquier tecla para continuar...\n");
            Console.ReadKey();
            Console.Clear();

            // ═══════════════════════════════════════════════════════════
            // Mostrar datos finales
            // ═══════════════════════════════════════════════════════════
            Console.WriteLine("║ PASO 3: DATOS FINALES DE LAS CUENTAS");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            cuenta1.MostrarDetalles();
            cuenta2.MostrarDetalles();

            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║              PROGRAMA FINALIZADO               ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝\n");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
