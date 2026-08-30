using System;

namespace CuentasBancarias
{
    /// <summary>
    /// Clase que representa una cuenta bancaria con operaciones básicas.
    /// </summary>
    internal class CuentaBancaria
    {
        // Atributos privados
        private string nombreTitular;
        private string numeroCuenta;
        private decimal saldo;

        /// <summary>
        /// Constructor que inicializa todos los atributos de la cuenta.
        /// </summary>
        /// <param name="nombreTitular">Nombre del titular de la cuenta</param>
        /// <param name="numeroCuenta">Número único de la cuenta</param>
        /// <param name="saldoInicial">Saldo inicial de la cuenta</param>
        public CuentaBancaria(string nombreTitular, string numeroCuenta, decimal saldoInicial)
        {
            this.nombreTitular = nombreTitular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldoInicial;
        }

        /// <summary>
        /// Realiza un depósito a la cuenta.
        /// </summary>
        /// <param name="monto">Cantidad a depositar</param>
        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a depositar debe ser mayor a 0.");
                return;
            }

            saldo += monto;
            Console.WriteLine($"✓ Depósito exitoso: ${monto:F2}");
            Console.WriteLine($"  Nuevo saldo: ${saldo:F2}\n");
        }

        /// <summary>
        /// Realiza un retiro de la cuenta validando saldo suficiente.
        /// </summary>
        /// <param name="monto">Cantidad a retirar</param>
        public void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: El monto a retirar debe ser mayor a 0.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine($"Error: Saldo insuficiente. Saldo disponible: ${saldo:F2}\n");
                return;
            }

            saldo -= monto;
            Console.WriteLine($"✓ Retiro exitoso: ${monto:F2}");
            Console.WriteLine($"  Nuevo saldo: ${saldo:F2}\n");
        }

        /// <summary>
        /// Muestra los detalles completos de la cuenta en la consola.
        /// </summary>
        public void MostrarDetalles()
        {
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("        DETALLES DE LA CUENTA");
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine($"Titular:        {nombreTitular}");
            Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
            Console.WriteLine($"Saldo Actual:   ${saldo:F2}");
            Console.WriteLine("═══════════════════════════════════════\n");
        }
    }
}
